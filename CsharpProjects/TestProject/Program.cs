// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

// Random dice = new();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
// Console.WriteLine();


// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll3) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }

//     Console.WriteLine($"Your total including the bonus: {total}");
// }

// if (total >=16 ){
//     Console.WriteLine("Ganhou um carro");
// }
// else if(total >=10){
//     Console.WriteLine("Ganhou um Laptop");

// }
// else if(total == 7){
//     Console.WriteLine("Ganhou uma viagem");
// }
// else{
//     Console.WriteLine("Ganhou um gato");
// }

//Random random = new Random();
// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;
// Console.WriteLine(daysUntilExpiration);

// if (daysUntilExpiration == 0){
//     Console.WriteLine("Your subscription has expired.");
// }
// else if(daysUntilExpiration == 1){
//     Console.WriteLine(@"Your subscription expires within a day!
// Renew now and save 20%!");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <=5 ){
//     Console.WriteLine($@"Your subscription expires in {daysUntilExpiration} days.
// Renew now and save 10%!");
//      discountPercentage =10;
// }
// else if(daysUntilExpiration <=10 ){
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }
// if (daysUntilExpiration > 0 ){
//     Console.WriteLine($"Voce recebeu um desconto de: {discountPercentage}% ");
// }



// string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

// // fraudulentOrderIDs[3] = "D000";

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// string[] names = ["Rowena", "Robin", "Bao"];
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// int[] inventory = [200, 450, 700, 175, 250];
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory){
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");


// string[] array = ["B123","C234","A345","C15","B177","G3003","C235","B179"];
// foreach(string i in array){
//     if(i.StartsWith("B")){
//         Console.WriteLine(i);
//     }

// }

//Criar e usar comentarios de codigo
Random random = new();
string[] orderIDs = new string[5]; //Criando um array
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}


// //Exemplo 1:
// Console
// .
// WriteLine
// ("Meu amor"
// );

// Console.WriteLine();

// //Exemplo 2

// string firstWord="hello"; string secondWord="exemplo 2";Console.WriteLine(firstWord + secondWord);

/*
Esse codigo retorna uma palavra ao contrario
*/

string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();

Array.Reverse(charMessage);
int x = 0;

foreach (char i in charMessage) { if (i == 'o') { x++; } }

string new_message = new String(charMessage);

Console.WriteLine(new_message);

Console.WriteLine($"'o' appears {x} times.");