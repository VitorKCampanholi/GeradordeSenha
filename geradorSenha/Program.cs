//using System.Text;

//Console.ForegroundColor = ConsoleColor.DarkGreen;
//Console.WriteLine(" == GERADOR SENHAS ALEATÓRIAS ==");

//Console.Write("    Digite Tamanho Caracter : ");

//if(!int.TryParse(Console.ReadLine(), out int tamanho) || tamanho <= 0)
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Tamanho inválido, digite um tamanho númerico.");
//    return;
//}
//string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%&*";

//StringBuilder senha = new();

//Random random = new();

//for(int i = 0; i < tamanho; i++)
//{
//    int indice = random.Next(caracteres.Length);
//    senha.Append(caracteres[indice]);
//}

//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine($"\n  Senha gerada : \n  {senha}  ");

using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string url = "https://www.youtube.com/watch?v=Mmv9V97w0sA&list=RDMmv9V97w0sA&start_radio=1";

        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "yt-dlp.exe",
            Arguments = $"-x --audio-format mp3 {url}",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        Process process = new Process();
        process.StartInfo = psi;
        process.Start();
        process.WaitForExit();

        Console.WriteLine("Download concluído!");
    }
}