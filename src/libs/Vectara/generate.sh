dotnet tool restore
rm -rf Generated
curl -L -o openapi.yaml https://docs.vectara.com/vectara-oas-v2.yaml
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
if [ $? -ne 0 ]; then
  echo "Failed, exiting..."
  exit 1
fi
dotnet tool run autosdk generate openapi.yaml \
  --namespace Vectara \
  --clientClassName VectaraClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations
