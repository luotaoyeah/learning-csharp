using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace P12;

public class Program
{
    public static void Main(string[] args)
    {
        // await DownloadHtmlAsync01();

        // int length = await DownloadHtmlAsync02();
        // Console.WriteLine(length);

        /*
         * Wait() 和 Result 会阻塞线程
         */

        // DownloadHtmlAsync01().Wait();

        int length = DownloadHtmlAsync02().Result;
        Console.WriteLine(length);
    }

    private static async Task DownloadHtmlAsync01()
    {
        Directory.CreateDirectory(@"D:/temp/p12");

        using var httpClient = new HttpClient();
        string html = await httpClient.GetStringAsync("https://stackoverflow.com/");

        string path = @"D:/temp/p12/000.txt";
        await File.WriteAllTextAsync(path, html);
    }

    private static async Task<int> DownloadHtmlAsync02()
    {
        Directory.CreateDirectory(@"D:/temp/p12");

        using var httpClient = new HttpClient();
        string html = await httpClient.GetStringAsync("https://stackoverflow.com/");

        string path = @"D:/temp/p12/001.txt";
        await File.WriteAllTextAsync(path, html);

        return html.Length;
    }
}
