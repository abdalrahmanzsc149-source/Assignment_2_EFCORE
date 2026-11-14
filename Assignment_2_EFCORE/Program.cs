using Assignment_2_EFCORE.Data;

using var context = new EventHubDbContext();
await context.Database.EnsureCreatedAsync();
Console.WriteLine("Database created successfully!");