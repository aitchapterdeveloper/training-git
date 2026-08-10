using System.Threading.Tasks;
using System.Threading;

namespace GitTrainingDemo.Services
{

    public class Asyncronus
    {
        public async Task<string> GetDataAsync()
        {
            await Task.Delay(5000);
            return "Data selesai";
        }

        public async Task<string> GetUserNameAsync(int id)
        {
            await Task.Delay(2000);

            return $"User untuk id: {id}";
        }

        public string GetData(int id)
        {
            Thread.Sleep(2000);
            return $"Data untuk id: {id}";
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
    }
}