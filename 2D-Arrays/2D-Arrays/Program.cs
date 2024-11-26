int[,] numbers = new int[3, 5]; //3 rijen, 5 kolommen

//Eerste rij opvullen met random getallen
Random random = new Random();
for(int col = 0; col < numbers.GetLength(1); col++)
{
    numbers[0, col] = random.Next(0,11);
}

//Tweede rij opvullen met user input

Console.WriteLine($"Geef {numbers.GetLength(1)} getallen voor het opvullen van de tweede rij!");

for (int col = 0; col < numbers.GetLength(1); col++)
{
    Console.Write($"Getal {col + 1}: ");
    numbers[1, col] = int.Parse(Console.ReadLine());
}


//Derde rij opvullen met som van de eerste twee rijen

for (int col = 0; col < numbers.GetLength(1) ; col++)
{
    numbers[2, col] = numbers[0, col] + numbers[1, col];
}


for (int row = 0; row < numbers.GetLength(0); row++)
{
    Console.Write($"Rij {row + 1} ==>\t");

    for (int col = 0; col < numbers.GetLength(1); col++)
    {
        Console.Write($"{numbers[row, col]}\t");
    }

        Console.WriteLine();
}

Console.WriteLine("Druk op een toets om af te sluiten.");
Console.ReadKey();