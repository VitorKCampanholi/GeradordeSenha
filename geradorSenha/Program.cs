using System.Text;

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(" == GERADOR SENHAS ALEATÓRIAS ==");

Console.Write("    Digite Tamanho Caracter : ");

if (!int.TryParse(Console.ReadLine(), out int tamanho) || tamanho <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Tamanho inválido, digite um tamanho númerico.");
    return;
}
string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%&*";

StringBuilder senha = new();

Random random = new();

for (int i = 0; i < tamanho; i++)
{
    int indice = random.Next(caracteres.Length);
    senha.Append(caracteres[indice]);
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\n  Senha gerada : \n  {senha}  ");