
// for (int i = 1; i < 101; i++)
// {

//     if ((i % 3 == 0 && i % 5 == 0))
//         Console.WriteLine($"{i} - FizzBuzz");


//     else if(i % 3 == 0)
//         Console.WriteLine($"{i} - fizz");

//     else if (i % 5 == 0)
//         Console.WriteLine($"{i} - Buzz");


//     else
//         Console.WriteLine($"{i}");

// }

// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine($"Numero gerado: {current}");
// } while (current != 7);
// Console.WriteLine("Fim do loop! Número 7 encontrado.");

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/



// Random ataque = new Random();
// int heroi = 10;
// int vilao = 10;
// do {

//     int dano = ataque.Next(1, 11);
//     vilao -= dano;
//     Console.WriteLine($"O vilao foi atacado, tomou {dano} e sua vida é {vilao}");

//     if(vilao <= 0) continue;

//     dano = ataque.Next(1,11);
//     heroi -= dano;
//     Console.WriteLine($"O heroi foi atacado, tomou {dano} e sua vida é {heroi}");


// }while(heroi > 0 && vilao > 0 );

// Console.WriteLine(heroi > vilao ? "Heroi vence" : "vilao vence");


int numero;
int valor1 = 5;
int valor2 = 10;

while (true)
{
    Console.Write($"Digite um valor de inteiro entre {valor1} e {valor2}: ");
    string entrada = Console.ReadLine();

    if (int.TryParse(entrada, out numero) && numero >= valor1 && numero <= valor2)
    {
        break;
    }
    Console.WriteLine($"{entrada}, invalido");

}
Console.WriteLine("Correto");