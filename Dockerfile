FROM microsoft/dotnet:1.1-sdk AS build
WORKDIR /app
COPY * /app/
RUN dotnet restore && dotnet build -o bin

FROM microsoft/dotnet:1.1-runtime
ENV TZ="Etc/UTC"
WORKDIR /app
COPY --from=build /app/ /app/
CMD ["dotnet", "bin/TzTest.dll"]
