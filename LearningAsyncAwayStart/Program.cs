using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace LearningAsyncAwayStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("downloading file");
            Download();
            Console.ReadLine();

        }


        /**
         * Download is an async function which means that it will allow for the main program to continue down its program sequence whilst it completes what is within the Download function.
         * However, within the Download function is an await clause. This clause makes the function wait until it has completed its specified task after the await clause.
         */
        static async void Download()
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync("http://rouxacademy.com");
            Console.WriteLine("Download Complete\n" + data);
        }
    }


}
