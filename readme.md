# Azure Cosmos DB for Table client library samples for .NET



## Getting started

This repo has a [devcontainer](https://containers.dev) environment making it easy to get started.



### Run the app

Configure your Azure Cosmos DB credentials as environment variables.

```bash
export COSMOS_ENDPOINT="<cosmos-account-URI>"
export COSMOS_KEY="<cosmos-account-PRIMARY-KEY>"
```

> **💡 TIP**: If you don't have an Azure Cosmos DB account, [create a free account](https://cosmos.azure.com/try/).

Run the quickstart sample app using the [`Azure.Data.Tables`](https://www.nuget.org/packages/Azure.Data.Tables) package from NuGet.

```bash
cd 001-quickstart/
dotnet add package Azure.Data.Tables
dotnet run
```

### Validate any changes you make

If you change the code, run the formatter and test the build.

```bash
dotnet format

dotnet build
```
