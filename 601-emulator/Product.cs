// <entity>
using Azure;
using Azure.Data.Tables;

public record Product : ITableEntity
{
    public required string RowKey { get; set; }

    public required string PartitionKey { get; set; }

    public required string Name { get; init; }

    public ETag ETag { get; set; }

    public DateTimeOffset? Timestamp { get; set; }
}
// </entity>