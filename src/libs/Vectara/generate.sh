#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://docs.vectara.com/vectara-oas-v2.yaml

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://docs.vectara.com/vectara-oas-v2.yaml

# Remove x-fern-sdk-group-name and x-fern-sdk-method-name to use clean OpenAPI tags
# for sub-client grouping (avoids tag↔group PascalCase collisions that cause "2" suffixes)
# Handles multi-line values (e.g., YAML sequences like "x-fern-sdk-group-name:\n- auth")
python3 -c "
import re, sys

with open('openapi.yaml') as f:
    lines = f.readlines()

out = []
skip_indent = None
for line in lines:
    # If we're skipping continuation lines of a removed key
    if skip_indent is not None:
        # A continuation line is more indented or a sequence item at same level
        stripped = line.strip()
        indent = len(line) - len(line.lstrip())
        if indent > skip_indent or (indent == skip_indent and stripped.startswith('- ')):
            continue
        else:
            skip_indent = None

    stripped = line.strip()
    if stripped.startswith('x-fern-sdk-group-name:') or stripped.startswith('x-fern-sdk-method-name:'):
        # Check if value is on the same line (scalar) vs next line (block sequence/mapping)
        key_part = stripped.split(':', 1)
        value_part = key_part[1].strip() if len(key_part) > 1 else ''
        if not value_part:
            # Value is on subsequent lines — skip them too
            skip_indent = len(line) - len(line.lstrip())
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
