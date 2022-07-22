using System.Globalization;

//string[] vet = Console.ReadLine().Split(' ');

//string name = vet[0];
//char sex = char.Parse(vet[1]);
//int age = int.Parse(vet[2]);
//double height = double.Parse(vet[3], CultureInfo.InvariantCulture);

//Console.WriteLine(name);
//Console.WriteLine(sex);
//Console.WriteLine(age);
//Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

//  Exercício de fixação

Console.WriteLine("Entre com seu nome Completo:");
string name = Console.ReadLine();

Console.WriteLine("quantos quartos tem na sua casa?");
int bedrooms = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto:");
double price =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com seu nome, idade e altura (mesma linha)");
string[] vect = Console.ReadLine().Split(' ');

string lastName = vect[0];
int age = int.Parse(vect[1]);
double height = double.Parse(vect[2], CultureInfo.InvariantCulture);

Console.WriteLine(name);
Console.WriteLine(bedrooms);
Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(lastName);
Console.WriteLine(age);
Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
