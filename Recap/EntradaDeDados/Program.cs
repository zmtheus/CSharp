using System.Globalization;

string[] vet = Console.ReadLine().Split(' ');

string name = vet[0];
char sex = char.Parse(vet[1]);
int age = int.Parse(vet[2]);
double height = double.Parse(vet[3], CultureInfo.InvariantCulture);

Console.WriteLine(name);
Console.WriteLine(sex);
Console.WriteLine(age);
Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));