using RedisCache;

var cache = RedisHelper.Database;
await cache.StringSetAsync("OURKEY", "JORDAN");

var value = await cache.StringGetAsync("OURKEY");

for(int a = 0; a < 100; a++)
{
    await cache.StringSetAsync($"OURKEY_{a}", $"JORDAN_{a}");
}
for (int a = 0; a < 100; a++)
{
    Console.WriteLine( await cache.StringGetAsync($"OURKEY_{a}"));
}
