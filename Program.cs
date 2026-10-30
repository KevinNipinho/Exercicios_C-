// Exercícos 1
/*
// 1.
Console.Write("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine()!);

Console.Write("Digite sua cidade: ");
string? cidade = Console.ReadLine();

// 2.
Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos e sou de {cidade}");
*/
// Exercícios 2
/*
// 1.
Console.Write("Digite o nome do produto: ");
string nomeProduto = Console.ReadLine()!;

Console.Write("Digite a quantidade comprada: ");
int quantidade = int.Parse(Console.ReadLine()!);

Console.Write("Digite o preço unitário: R$ ");
decimal precoUnitario = decimal.Parse(Console.ReadLine()!);

// 2.
decimal valorTotal = quantidade * precoUnitario;

// 3.
Console.WriteLine("\n--- Resumo da compra ---");
Console.WriteLine($"Produto: {nomeProduto}");
Console.WriteLine($"Quantidade: {quantidade}");
Console.WriteLine($"Preço unitário: R$ {precoUnitario:F2}");
Console.WriteLine($"Valor total: R$ {valorTotal:F2}");
*/

// Exercícios 3
/*
// 1. 
Console.Write("Digite o nome do aluno: ");
string nomeAluno = Console.ReadLine()!;

Console.Write("Digite a nota do aluno (0 a 10): ");
decimal nota = decimal.Parse(Console.ReadLine()!);

// 2.
switch (nota)
{
    // 3.
    case < 0 or > 10:
        Console.WriteLine("Nota inválida! Digite uma nota entre 0 e 10.");
        break;

    case >= 7:
        Console.WriteLine($"Aluno: {nomeAluno}");
        Console.WriteLine($"Nota: {nota:F2}");
        Console.WriteLine("Classificação: Aprovado");
        break;

    case >= 5:
        Console.WriteLine($"Aluno: {nomeAluno}");
        Console.WriteLine($"Nota: {nota:F2}");
        Console.WriteLine("Classificação: Recuperação");
        break;

    default:
        Console.WriteLine($"Aluno: {nomeAluno}");
        Console.WriteLine($"Nota: {nota:F2}");
        Console.WriteLine("Classificação: Reprovado");
        break;
}
*/

// Exercícios 4

/*
// 1.

Console.Write("Digite um numero: ");
int numero = int.Parse(Console.ReadLine()!);

Console.WriteLine($"\n--- Tabuada do {numero} ---");
// 2. 
for (int i = 1; i <= 10; i++)
{
    // 3. 
    int resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}
*/

// Exercícios 5
/*
// 1.

int numeroSecreto = 67;
int tentativa;
int quantidadeTentativas = 0;

Console.WriteLine("=== Adivinhe o número ===");

Console.Write("Digite um número inteiro: ");
// 2.
tentativa = int.Parse(Console.ReadLine()!);
quantidadeTentativas++;

do
{
    // 3.
    if (tentativa < numeroSecreto)
    {
        Console.WriteLine("O número secreto é maior!");
    }
    else
    {
        Console.WriteLine("O número secreto é menor!");
    }

    Console.Write("Tente novamente: ");
    tentativa = int.Parse(Console.ReadLine()!);
    quantidadeTentativas++;

}
// 4. 
while (tentativa != numeroSecreto);

// 5.
Console.WriteLine("\nParabéns! Você acertou o número secreto!");
Console.WriteLine($"Quantidade de tentativas: {quantidadeTentativas}");
*/

// Exercício 6
/*
// 1.
int Somar(int numero1, int numero2)
{
    return numero1 + numero2;
}

// 2.
int Multiplicar(int numero1, int numero2)
{
    return numero1 * numero2;
}

// 3.
Console.Write("Digite o primeiro número: ");
int numero1 = int.Parse(Console.ReadLine()!);

Console.Write("Digite o segundo número: ");
int numero2 = int.Parse(Console.ReadLine()!);

int soma = Somar(numero1, numero2);
int multiplicacao = Multiplicar(numero1, numero2);

// 4. 
Console.WriteLine($"\nSoma: {numero1} + {numero2} = {soma}");
Console.WriteLine($"Multiplicação: {numero1} * {numero2} = {multiplicacao}");
*/
