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

// Exercício 7
/*
// 1.
int[] notas = new int[3];

// 2.
for (int i = 0; i < 3; i++)
{
    Console.Write("Digite uma nota: ");
    notas[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine("Notas cadastradas:");

// 3.
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(notas[i]);
}

// 4. 
int soma = 0;

foreach (int nota in notas)
{
    soma = soma + nota;
}

int media = soma/3;

// 5. 
Console.WriteLine($"Média: {media}");
*/

// Exercicio 8
/*
// 1.
int[] numeros = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write("Digite um número: ");
    numeros[i] = int.Parse(Console.ReadLine()!);
}

// 2.
int pares = 0;
int maior = numeros[0];
Console.WriteLine($"--- Tabela de números ---");

for (int i = 0; i < 5; i++)
{
    
    Console.WriteLine(numeros[i]);

// 3/4.
    if (numeros[i] % 2 == 0)
    {
        pares++;
    }

    if (numeros[i] > maior)
    {
        maior = numeros[i];
    }
}

// 5.
Console.WriteLine($"Quantidade de pares: {pares}");
Console.WriteLine($"Maior número: {maior}");
*/

// Exercicio 9
/*
// 1.
List<string> Produtos = new List<string>();

// 2.
for (int i = 1; i <= 3; i++)
{
    Console.Write($"Digite o nome do produto {i}: ");
    string produto = Console.ReadLine()!;
    Produtos.Add(produto);
}

// 3. 
Console.WriteLine("\nProdutos cadastrados:");
foreach (var prod in Produtos)
{
    Console.WriteLine($"- {prod}");
}

// 4.
Console.Write("\nDigite o nome de um produto para verificar se está na lista: ");
string buscaProduto = Console.ReadLine()!;

if (Produtos.Contains(buscaProduto)) 
{
    Console.WriteLine($"O produto '{buscaProduto}' está na lista!");
}
else
{
    Console.WriteLine($"O produto '{buscaProduto}' NÃO foi encontrado.");
}

// 5.
Console.Write("\nDigite o nome do produto que deseja remover: ");
string produtoParaRemover = Console.ReadLine()!;

bool removido_com_sucesso = Produtos.Remove(produtoParaRemover);

if (removido_com_sucesso)
{
    Console.WriteLine($"Produto '{produtoParaRemover}' removido com sucesso.");
}
else
{
    Console.WriteLine($"Não foi possível remover: '{produtoParaRemover}' não estava na lista.");
}

// 6.
Console.WriteLine("\nLista de produtos atualizada:");
if (Produtos.Count > 0)
{
    foreach (var prod in Produtos)
    {
        Console.WriteLine($"- {prod}");
    }
}
else
{
    Console.WriteLine("(A lista está vazia)");
}
*/

// Exercicio 10

List<string> produtos = new List<string>
{
    "Notebook",
    "Mouse",
    "Teclado",
    "Monitor",
    "Webcam"
};

// 1.
Console.Write("Digite o nome do produto: "); 
string buscaProduto = Console.ReadLine()!;

// 2. 
string? resultado = produtos.Find(n => n.Contains(buscaProduto, StringComparison.OrdinalIgnoreCase));

// 3.
if (resultado != null)
{
    Console.WriteLine($"Produto encontrado: {resultado}");
}
else
{
    Console.WriteLine("Nenhum produto corresponde à busca.");
}
