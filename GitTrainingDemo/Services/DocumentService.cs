using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GitTrainingDemo.Services
{
    public class DocumentService
    {
        public string DownloadDocument ()
        {
            Task.Delay(2000).Wait();
            return "Downloaded";
        }
        public string UploadDocument ()
        { 
            Task.Delay(2000).Wait();
            return "Uploaded";
        }
        public string CompressDocument ()
        { 
            Task.Delay(2000).Wait();
            return "Compressed";
        }

        public async Task<string> DownloadDocumentAsync()
        {
            await Task.Delay(2000);
            return "Downloaded";
        }
        public async Task<string> UploadDocumentAsync ()
        {
            await Task.Delay(2000);
            return "Uploaded";
        }
        public async Task<string> CompressDocumentAsync()
        {
            await Task.Delay(2000);
            return "Compressed";
        }

        public void GetDocumentSync ()
        {
            var download = DownloadDocument();
            Console.WriteLine(download);
            var compress = CompressDocument();
            Console.WriteLine(compress);
            var upload = UploadDocument();
            Console.WriteLine(upload);
        }

        public async Task<List<string>> GetDocumentAsync ()
        { 
            var download = DownloadDocumentAsync();
            var compress = CompressDocumentAsync();
            var upload = UploadDocumentAsync();

            await Task.WhenAll(download, compress, upload);
            //Console.WriteLine(await download);
            //Console.WriteLine(await compress);
            //Console.WriteLine(await upload);

            List<string> result = new List<string>();
            result.Add(await download);
            result.Add(await compress);
            result.Add(await upload);
            return result;
        }
    }

    public class EmailManager
    {
        public void SendWelcomeEmail (string email)
        {
            Console.WriteLine($"Send email to: {email}");
        }
    }
}
