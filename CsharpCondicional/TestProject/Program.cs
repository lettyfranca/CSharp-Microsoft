//Considerando que as regras do jogo especificam que "se a soma dos três dados, mais os bônus, é maior ou igual a 15, você ganha o jogo"

//instanciar objeto da classe de gerar números aleatórios
Random dado = new Random();

//gerar os números aleatórios e salvar em variáveis
int rolar1 = dado.Next(1,7);
int rolar2 = dado.Next(1,7);
int rolar3 = dado.Next(1,7);

//somar os números e salver em variável
int total = rolar1 + rolar2 + rolar3;

//condicional para verificar se houve resultado duplicado = bonus
if ((rolar1 == rolar2) || (rolar2 == rolar3) || (rolar1 == rolar3))
{
    Console.WriteLine("Você rolou dados iguais! +2 bônus ao total");
    total += 2;
}

if ((rolar1 == rolar2) && (rolar2 == rolar3))
{
    Console.WriteLine("Você rolou 3 dados iguais! +6 bônus ao total");
    total += 6;
}

//condicional para verificar se o usuário ganhou o jogo
if (total >= 15)
{
    Console.WriteLine("Você ganhou!");
}

if (total < 15)
{
    Console.WriteLine("Você perdeu!");
}

Console.WriteLine($"Ao rolar os dados: {rolar1} + {rolar2} + {rolar3} = {total}");