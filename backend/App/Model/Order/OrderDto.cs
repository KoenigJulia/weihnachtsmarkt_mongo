﻿using MongoDB.Bson;

namespace MongoDBDemoApp.Model.Order;

public class OrderDto
{
    public string? Id { get; set; } = default!;
    public string? Name { get; set; } = default!;
    public DateTime Created { get; set; }
    public string? CustomerId { get; set; } = default!;
    public List<string?> Prodcuts { get; set; } = default!;
}