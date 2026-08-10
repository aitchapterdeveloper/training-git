using System;
using System.Collections.Generic; //List
using System.Threading.Tasks; //Thread
using System.Diagnostics; //Stopwatch
class AsyncService
{
    public async Task<string> GetDataAsync(int id)
    {
        await Task.Delay(300);
        return $"Data untuk id: {id}"; 
    }

    public async Task<string> GetFormattedDataAsync(int id)
    {
        var rawData = await GetDataAsync(id);
        return $"Formatted: {rawData}";
    }

    public string stopwatchSync()
    {
        var swSync = Stopwatch.StartNew();
        DownloadData();
        CompressFile();
        UploadingFile();
        swSync.Stop();
        return $"{swSync.ElapsedMilliseconds}";
    }

    public async Task<string> stopwatchAsync()
    {
        var swSync = Stopwatch.StartNew();
        var task1 = AsyncDownloadData();
        var task2 = AsyncCompressFile();
        var task3 = AsyncUploadingFile();
        await Task.WhenAll(task1, task2, task3);
        swSync.Stop();
        return $"{swSync.ElapsedMilliseconds}";
    }

    private void DownloadData()
    {
        Task.Delay(2000).Wait();
        Console.WriteLine("Downloading Data");
    }
    private void CompressFile()
    {
        Task.Delay(2000).Wait();
        Console.WriteLine("Compressing File");
    }
    private void UploadingFile()
    {
        Task.Delay(2000).Wait();
        Console.WriteLine("Uploading File");
    }

    private async Task AsyncDownloadData()
    {
        await Task.Delay(2000);
    }
    private async Task AsyncCompressFile()
    {
        await Task.Delay(2000);
    }
    private async Task AsyncUploadingFile()
    {
        await Task.Delay(2000);
    }
}