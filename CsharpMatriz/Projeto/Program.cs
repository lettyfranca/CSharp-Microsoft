//O operador new cria uma instância de uma matriz na memória do computador que pode conter três valores de cadeia de caracteres.
//o primeiro conjunto de colchetes [] simplesmente indica ao compilador que a variável de nome fraudulentOrderIDs é uma matriz. Já o segundo conjunto de colchetes [3] indica o número de elementos que a matriz conterá.

/*string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
fraudulentOrderIDs[3] = "D000";*/

string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

//Para determinar o tamanho de uma matriz, você pode usar a propriedade Length.
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");