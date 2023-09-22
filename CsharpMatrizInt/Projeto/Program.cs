int[] inventario = {200, 450, 700, 175, 250};
int sum = 0;
int caixa = 0;

foreach (int itens in inventario)
{
    sum += itens;
    caixa++;
    Console.WriteLine($"Caixa {caixa} = {itens} itens (Execução total: {sum})");
}
Console.WriteLine($"Nós temos {sum} itens no inventário.");