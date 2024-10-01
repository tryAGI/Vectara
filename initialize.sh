dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Vectara \
  VectaraClient \
  https://docs.vectara.com/vectara-oas-v2.yaml \
  tryAGI \
  --output .
