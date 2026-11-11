using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTrainingDemo.Services
{
    public class Day3Services
    {
        public void linq (List<int> numbers)
        {
/*            List<int> results = (from angka in numbers
                                 where angka > 50000
                                 orderby angka
                                 select angka).ToList();
            foreach (int result in results)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("");*/
            List<int> results2 = numbers.Where(n => n > 50000).OrderByDescending(n => n).Select(n => n * 90/100).ToList();
            foreach (int result in results2)
            {
                Console.WriteLine("Result 2: " + result);
            }

            int count = results2.Count(n => n > 50000);
            int totalAllPrices = numbers.Sum();
/*            double averagePrices = numbers.Average();
*/            bool anyAbove200K = results2.Any(n => n > 200000);
            bool allAbove500K = results2.All(n => n > 5000);

            
            Console.WriteLine("Count: " + count);
            Console.WriteLine("Total Price: " + totalAllPrices);
            Console.WriteLine("Average Price: " + numbers.Average());
            Console.WriteLine("Any: " + anyAbove200K);
            Console.WriteLine("All: " + allAbove500K);

        }

        public void tesAggregate(List<int> numbers)
        {
            Console.WriteLine("Count: " + numbers.Count());
            Console.WriteLine("Sum: " + numbers.Sum());
            Console.WriteLine("Average: " + numbers.Average());
            Console.WriteLine("Any: " + numbers.Any(n => n == 2));
            Console.WriteLine("All: " + numbers.All(n => n % 2 == 0));

        }

        public async Task<string> GetDataInternalAsync(int id)
        {
            // Untuk library, ConfigureAwait(false)
            // menghindari penangkapan SynchronizationContext
            await Task.Delay(500).ConfigureAwait(false);
            return $"Data untuk id: {id}";
        }

        public async Task<string> GetFormattedDataAsync(int id)
        {
            var rawData = await GetDataInternalAsync(id);
            return $"Formatted: {rawData}";
        }

        public async Task GetUserEndpoint(int id)
        {
            var data = await GetFormattedDataAsync(id);
            Console.WriteLine("Get User Endpoint: " + data);
        }

        public static async Task<string> GetJudulFilmAsync(int id)
        {
            Task.Delay(300);
            return $"Film #{id}";
        }

        public async Task<string> GetInfoFilmAsync(int id)
        {
            string judul = await GetJudulFilmAsync(id);
            return $"Info: {judul}";
        }


    }
}
