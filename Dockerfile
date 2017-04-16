FROM microsoft/dotnet
WORKDIR /app
COPY * /app/
RUN dotnet build -o bin
CMD ["dotnet", "bin/TzTest.dll"]