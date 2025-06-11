using StackExchange.Redis;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching.Microsoft
{
    public class RedisCacheManager : ICacheService
    {
		private readonly IDatabase _database;

		public RedisCacheManager(IConfiguration configuration)
		{
			var redisConnectionString = configuration.GetConnectionString("Redis");
			var redis = ConnectionMultiplexer.Connect(redisConnectionString);
			_database = redis.GetDatabase();
		}

		public async Task<T> GetAsync<T>(string key)
		{
			var value = await _database.StringGetAsync(key);
			return value.HasValue ? JsonSerializer.Deserialize<T>(value) : default;
		}

		public async Task SetAsync<T>(string key, T value, TimeSpan? expiry = null)
		{
			var json = JsonSerializer.Serialize(value);
			await _database.StringSetAsync(key, json, expiry);
		}

		public async Task RemoveAsync(string key)
		{
			await _database.KeyDeleteAsync(key);
		}
	}
}
