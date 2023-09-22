//Considerando que as regras do jogo especificam que "se a soma dos três dados, mais os bônus, é maior ou igual a 15, você ganha o jogo"

//instanciar objeto da classe de gerar números aleatórios
Random dado = new Random();

//gerar os números aleatórios e salvar em variáveis
int rolar1 = dado.Next(1,7);
int rolar2 = dado.Next(1,7);
int rolar3 = dado.Next(1,7);

//somar os números e salver em variável
int total = rolar1 + rolar2 + rolar3;

//saída
Console.WriteLine($"Ao rolar os dados: {rolar1} + {rolar2} + {rolar3} = {total}");

//condicional para verificar se houve resultado duplicado = bonus
if ((rolar1 == rolar2) || (rolar2 == rolar3) || (rolar1 == rolar3))
{
    if ((rolar1 == rolar2) && (rolar2 == rolar3))
    {
        Console.WriteLine("Você rolou 3 dados iguais! +6 bônus ao total");
        total += 6;
    }
    else
    {
        Console.WriteLine("Você rolou 2 dados iguais! +2 bônus ao total");
        total += 2;
    }    
}

/*
Se a pontuação do jogador for maior ou igual a 16, ele ganhará um carro novo.
Se a pontuação do jogador for maior ou igual a 10, ele ganhará um laptop novo.
Se a pontuação do jogador for exatamente 7, ele ganhará uma viagem.
Caso contrário, ganhará um gatinho.
*/

//condicional para verificar se o usuário ganhou o jogo
if (total >= 16)
{
    Console.WriteLine("Você ganhou um carro novo!");
}
else if (total >= 10)
{
    Console.WriteLine("Você ganhou um laptop novo!");
}
else if (total == 7)
{
    Console.WriteLine("Você ganhou uma viagem!");
}
else 
{
    Console.WriteLine("Você ganhou um gatinho!");
}

