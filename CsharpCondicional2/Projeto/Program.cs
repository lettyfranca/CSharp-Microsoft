//instanciar um objeto da classe random
Random random = new Random();

int daysUntilExperation = random.Next(12);
int discountPercentage = 0;

//daysUntilExperation = 15;

if(daysUntilExperation == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if(daysUntilExperation == 1)
{
    Console.WriteLine("Your subscription expires within a day! \nRenew now and save 20%!");
}
else if(daysUntilExperation <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExperation} days. \nRenew now and save 10%!");
}
else if(daysUntilExperation <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
