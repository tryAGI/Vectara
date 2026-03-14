# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Vectara](https://vectara.com/) RAG-as-a-Service platform, auto-generated from the Vectara OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build Vectara.slnx

# Build for release (also produces NuGet package)
dotnet build Vectara.slnx -c Release

# Run integration tests (requires VECTARA_API_KEY env var)
dotnet test src/tests/IntegrationTests/Vectara.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Vectara && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** -- do not manually edit files in `src/libs/Vectara/Generated/`.

1. `src/libs/Vectara/openapi.yaml` -- the Vectara OpenAPI spec (fetched from `https://docs.vectara.com/vectara-oas-v2.yaml`)
2. `.config/dotnet-tools.json` -- pins the AutoSDK CLI version used for generation
3. `src/libs/Vectara/generate.sh` -- orchestrates: download spec, run AutoSDK CLI, output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Vectara/` | Main SDK library (`VectaraClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real Vectara API |
| `src/helpers/GenerateDocs/` | Documentation generator from integration tests |
| `src/helpers/TrimmingHelper/` | NativeAOT/trimming compatibility validator |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
