using System;
using System.Text.Json;

namespace InventoryManagement.Filter
{
    public static class JsonHelper
    {
        public static T Deserialize<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}