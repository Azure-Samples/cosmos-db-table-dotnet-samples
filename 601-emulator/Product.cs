// <entity>
public record Product : Azure.Data.Tables.ITableEntity
{
    public required string RowKey { get; set; }

    public required string PartitionKey { get; set; }

    public required string Name { get; init; }

    public Azure.ETag ETag { get; set; }

    public DateTimeOffset? Timestamp { get; set; }
}
// </entity>