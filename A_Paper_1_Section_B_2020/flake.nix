{
  description = "csharp dotnet 8 flake";
  inputs = {
    nixpkgs.url = "github:NixOS/nixpkgs/nixos-unstable";
    flake-utils.url = "github:numtide/flake-utils";
  };

  outputs =
    { self
    , nixpkgs
    , flake-utils
    , ...
    }:
    flake-utils.lib.eachDefaultSystem (
      system:
      let
        pkgs = nixpkgs.legacyPackages.${system};
      in
      {
        devShells.default = pkgs.mkShell {
          buildInputs = with pkgs; [
            dotnet-sdk_7
            dotnet-runtime_7
            dotnetPackages.Nuget
            omnisharp-roslyn
          ];

          DOTNET_ROOT = "\${XDG_DATA_HOME}/dotnet";
          DOTNET_CLI_TELEMETRY_OPTOUT = 1;
          DOTNET_SKIP_FIRST_TIME_EXPERIENCE = "true";

          shellHook = ''
            export NUGET_PACKAGES=$XDG_DATA_HOME/nuget
            export OMNISHARPHOME=$XDG_CONFIG_HOME/omnisharp
          '';
        };
      }
    );
}
