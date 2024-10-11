// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(value: "Run files, Wait...");
        ProcessStartInfo info = new ProcessStartInfo("BanPhimTiengViet.exe");
        Process.Start(info);
    }
}