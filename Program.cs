using StackExchange.Redis;
using System;
using System.Threading.Tasks;

namespace ReferenceConsoleRedisApp
{
  class Program
  {
    static readonly ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("redis-11137.c336.samerica-east1-1.gce.redns.redis-cloud.com:11137,password=*******");
    static async Task Main(string[] args)
    {
      var db = redis.GetDatabase();
    }
  }
}