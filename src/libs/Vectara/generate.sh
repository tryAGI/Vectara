#!/usr/bin/env bash
set -e
dotnet tool restore
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://docs.vectara.com/vectara-oas-v2.yaml
dotnet tool run autosdk generate openapi.yaml \
  --namespace Vectara \
  --clientClassName VectaraClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations
