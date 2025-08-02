using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        using var client = new HttpClient();
        string url = "https://openlibrary.org/search.json?q=harry+potter";

        Console.WriteLine("Fetching book data...");
        var response = await client.GetAsync(url);
        var content = await response.Content.ReadAsStringAsync();

        Console.WriteLine("Response:");
        Console.WriteLine(content.Substring(0, 500)); // Show first 500 chars
    }
}
