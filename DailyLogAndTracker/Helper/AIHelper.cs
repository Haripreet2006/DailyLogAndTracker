using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DailyLogAndTracker.Helper
{
    public static class AIHelper
    {
        private static string GetAPIKey()
        {
            string json = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, @"..\..\..\config.json"));
            var Jsondoc = JsonDocument.Parse(json);
            return Jsondoc.RootElement.GetProperty("GroqAPIkey").GetString();
        }

        public static async Task<string> GetDietData(string prompt)
        {
            string ApiKey = GetAPIKey();
            string Endpoint = "https://api.groq.com/openai/v1/chat/completions";

            using(HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ApiKey);
                var requestBody = new
                {
                    model = "deepseek-r1-distill-llama-70b",
                    messages = new[]
    {
        new {
            role = "user",
            content = @"You are a nutrition expert. Given a list of food items with quantity, return only the **total nutrition summary** as a strict JSON object, with:

- ""Calories"" in kcal  
- ""Protein"", ""Carbohydrates"", ""Fats"", and ""Fibre"" in grams  
- No explanation or text. Only return a compact JSON like:
  {
    ""Calories"": 230.5,
    ""Protein"": 12.3,
    ""Carbohydrates"": 40.1,
    ""Fats"": 5.6,
    ""Fibre"": 1.2
  }

Now analyze: " + prompt
        }
    },
                    temperature = 0.2
                };
                string promptJson = JsonSerializer.Serialize(requestBody);
                var content = new StringContent(promptJson, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(Endpoint, content);

                string RawData = await response.Content.ReadAsStringAsync();

                return RawData;
            }
        }
    }
}
