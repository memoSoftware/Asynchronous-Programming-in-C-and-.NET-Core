using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncCoin
{
    public class AsyncCoinManager
    {
        public async Task AcquireAsyncCoin()
        {
            Console.WriteLine($"Start call to long-running service at {DateTime.Now}");
            var result = await PretendToConnectToCoinServiceAsync();
            Console.WriteLine($"Finish call to long-running service at {DateTime.Now}");
            var savedColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"result: {result}");
            Console.ForegroundColor = savedColor;
        }
        private async Task<string> PretendToConnectToCoinServiceAsync()
        {
            // Simulate a long-running network connection
            await Task.Delay(5000);
            return "You've got 25 AsyncCoin!";
        }
    }

}