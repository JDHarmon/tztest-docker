FROM microsoft/dotnet
ENV TZ="America/New_York"
WORKDIR /app
COPY * /app/
RUN dotnet restore && dotnet build -o bin
CMD ["dotnet", "bin/TzTest.dll"]