using System.Text.Json;

namespace MedicinesDto
{
    class Program
    {
        public static readonly HttpClient HttpClient = new HttpClient();
        public static string uri = "https://localhost:7253/api/Medicines";

        static async Task Main()
        {
            string response = await client.GetStringAsync(uri);

            List<MedicinesDto> medicines = JsonSerializer.Deserialize<List<MedicinesDto>>(response);

            foreach (var item in medicines)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}