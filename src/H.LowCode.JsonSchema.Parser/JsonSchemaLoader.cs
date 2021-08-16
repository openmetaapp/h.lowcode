using H.LowCode.Utility;
using System;
using System.Net.Http;
using System.Net.Http.Json;

namespace H.LowCode.JsonSchema.Parser
{
    public static class JsonSchemaLoader
    {
        public static void Load(string id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5000");
            client.GetFromJsonAsync<RootJsonSchema>(id);
        }
    }
}
