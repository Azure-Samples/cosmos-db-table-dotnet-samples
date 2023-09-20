// <imports>
using Azure;
using Azure.Data.Tables;
// </imports>

// <client>
var serviceClient = new TableServiceClient(
    connectionString: "DefaultEndpointsProtocol=http;AccountName=localhost;AccountKey=C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==;TableEndpoint=http://localhost:8902/;"
);
// </client>

// <resources>
var client = serviceClient.GetTableClient(
    tableName: "cosmicworksproducts"
);

await client.CreateIfNotExistsAsync();
// </resources>

// <upsert>
var item = new Product
{
    RowKey = "68719518371",
    PartitionKey = "Surfboards",
    Name = "Kiama classic surfboard",
    Timestamp = DateTimeOffset.Now
};

await client.UpsertEntityAsync(
    entity: item,
    mode: TableUpdateMode.Replace
);
// </upsert>
