/*
//exercício 1

int Num;
Console.WriteLine("digite um número para contarmos até ele:");
Num = int.Parse(Console.ReadLine());
int i = 1; while (i <= Num) 
{
    Console.WriteLine(i);
    i++;
}
Console.WriteLine();
Thread.Sleep(2000);
Console.Clear();


//execício 2
int Nume;
Console.WriteLine("digite um número para contarmos os números pares até ele até ele:");
Nume = int.Parse(Console.ReadLine());
i = 1; while (i <= Nume)
{
    if (i == 1 || i % 2 == 0)
        Console.WriteLine(i);
    i++;
}
Console.WriteLine();
Thread.Sleep(2000);
Console.Clear();


//execício 3
int Numer;
Console.WriteLine("digite um número(menor que mil) para contarmos os números pares de mil até ele:");
Numer = int.Parse(Console.ReadLine());
if (Numer <= 1000)
{
    i = 1000; while (i > Numer)
    {
        if (i == 1000 || i % 2 == 0)
            Console.WriteLine(i);
        i--;
    }
}
else
{
    Console.WriteLine("O número é maior que mil");
}
Thread.Sleep(2000);
Console.Clear();


//execício 4
int valor = 0, Num1;
i = 0; while (true)
{
    Console.WriteLine("Digite números aleatótios para somarmos:");
    Num1 = int.Parse(Console.ReadLine());
    valor += Num1;
    i++;
    if (Num1 >= 0)
    {
        Console.Clear();
        Console.WriteLine("Último número positivo digitado:{0}", Num1);
        Console.WriteLine("A soma dos números até agora é de:{0}", valor);
        Console.WriteLine();
    }
    else if (Num1 < 0)
    {
        Console.Clear();
        Console.WriteLine("Último número negativo digitado:{0}", Num1);
        Console.WriteLine("A soma dos números até agora é de:{0}", valor);
        Console.WriteLine();
    }
    if (valor >= 200)
    {
        break;
    }
}
Thread.Sleep(2000);
Console.Clear();




// execício 5
int Num2;
do
{
    Console.WriteLine("Digite um número para que possamos descobrir seus divisores exatos:");
    Num2 = int.Parse(Console.ReadLine());
} while (Num2 <= 0);
i = 1; while (i <= Num2)
{
    i++;
    if (Num2 % i == 0)
    {
        Console.WriteLine("Os divisores exatos do número escolhido são:{0}", i);
    }
}

Thread.Sleep(2000);
Console.Clear();
Console.Clear();


*/

//execício 6

int[] numeros = new int[10];
int maior, menor;

int i = 0; while (i < 10)
{
    Console.Write($"Digite o {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine());
    i++;
}
maior = menor = numeros[0];
i = 1; while (i < 10)
{
    if (numeros[i] > maior)
    {
        maior = numeros[i];
    }
    if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
    i++;
}
Console.WriteLine($"O maior número digitado é: {maior}");
Console.WriteLine($"O menor número digitado é: {menor}");


Thread.Sleep(3000);
Console.Clear();



//execício 7
int numero;
int Pares = 0;
int Impar = 0;

Console.Clear();
Console.WriteLine("Digite uma sequência de números (digite 0 para parar)");
do
{
    Console.Write("Número: ");
    numero = int.Parse(Console.ReadLine());
    if (numero != 0)
    {
        if (numero % 2 == 0)
        {
            Pares += numero;
        }
        else
        {
            Impar += numero;
        }
    }
} while (numero != 0);
Console.WriteLine($"A soma dos números pares é: {Pares}");
Console.WriteLine($"A soma dos números ímpares é: {Impar}");
        