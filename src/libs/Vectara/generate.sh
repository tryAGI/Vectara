#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://docs.vectara.com/vectara-oas-v2.yaml

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://docs.vectara.com/vectara-oas-v2.yaml

# Remove x-fern-sdk-group-name and x-fern-sdk-method-name to use clean OpenAPI tags
# for sub-client grouping (avoids tag↔group PascalCase collisions that cause "2" suffixes)
python3 -c "
import re, sys

with open('openapi.yaml') as f:
    lines = f.readlines()

out = []
for line in lines:
    stripped = line.strip()
    if stripped.startswith('x-fern-sdk-group-name:') or stripped.startswith('x-fern-sdk-method-name:'):
        continue
    out.append(line)

with open('openapi.yaml', 'w') as f:
    f.writelines(out)
"

autosdk generate openapi.yaml \
  --namespace Vectara \
  --clientClassName VectaraClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
