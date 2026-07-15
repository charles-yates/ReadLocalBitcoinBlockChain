using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task MainAPI()
    {
        using HttpClient client = new HttpClient();
        string address = "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa"; // Genesis Address
        string url = $"https://blockchain.info/q/addressbalance/{address}";

        try
        {
            string rawBalance = await client.GetStringAsync(url);
            decimal balanceBtc = decimal.Parse(rawBalance) / 100_000_000m; // Convert Satoshis to BTC
            Console.WriteLine($"Balance: {balanceBtc} BTC");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading data: {ex.Message}");
        }
    }
}
