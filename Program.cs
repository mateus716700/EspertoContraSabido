

Console.WriteLine("Esperto Contra Sabido\n");

Console.Write("Digite a quantiadade dos alimentos que vão ser distribuidos? ");
if (!int.TryParse(Console.ReadLine(), out int total) || total <= 0)
{
    Console.WriteLine("ERRO!!! . Coloque uma quantia válida.");
    return;
}
    
int P = 0, raposa = 0, rodada = 1;

while (total > 0)
{
    Console.Write($"{rodada} para você. ");
    total--; P++;

    int qtd = Math.Min(rodada, total);
    Console.WriteLine(string.Join(", ", Enumerable.Range(1, qtd)) + " para mim.");

    raposa += qtd;
    total -= qtd;
    rodada++;
}

Console.WriteLine($"\nPica-pau recebeu {P} .");
Console.WriteLine($"Raposinha recebeu {raposa} .");