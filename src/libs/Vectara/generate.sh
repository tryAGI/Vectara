#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://docs.vectara.com/vectara-oas-v2.yaml

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://docs.vectara.com/vectara-oas-v2.yaml
autosdk generate openapi.yaml \
  --namespace Vectara \
  --clientClassName VectaraClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
