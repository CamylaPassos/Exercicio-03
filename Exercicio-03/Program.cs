// See https://aka.ms/new-console-template for more information
int abase;
int altura;
int resultado;

Console.WriteLine("Informe a base:");
abase = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a altura:");
altura = Convert.ToInt32(Console.ReadLine());

resultado = abase * altura;

Console.WriteLine("A área do retangulo corresponde a: " + resultado);

Console.ReadLine();
