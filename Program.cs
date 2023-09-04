using exercicio_090223;

// Crie um algoritmo em C# que, tendo 2 variáveis contendo a base e a altura de um triangulo, calcule sua área. ( b * h / 2 )

int b = 20; // Base
int h = 10; // Al

// Cálculo da área
int a = (b * h) / 2;

// Exibe resultado
Console.WriteLine("Área: " + a);

// ⁠Crie um algoritmo em C# que "calcule" e exiba a tabuada do 5 armazenando os resultados em um vetor.
int[] resultado = new int[10];

// resultado[0] = 1 * 5;
// resultado[1] = 2 * 5;
// resultado[2] = 3 * 5;

// resultado[9] = 10 * 5;

for(int cont = 0;cont < 10;cont++) {
    resultado[cont] = (cont + 1) * 5;
}

foreach(int item in resultado) { 
    Console.WriteLine(item);
}

// Exemplo Procedural

String nomeCliente = "Marco Carvalho";
double saldoCliente = 546.85;

String nomeCliente2 = "Maria Aparecida";
double saldoCliente2 = 621.52;

// Exemplo OO
Cliente cliente1 = new Cliente();
cliente1.nome = "Marco Carvalho";
cliente1.saldo = 546.85;
cliente1.aumentarSaldo(100);

Cliente cliente2 = new Cliente();
cliente2.nome = "Maria Aparecida";
cliente2.saldo = 621.52;

Cliente cliente3 = cliente1;
cliente3.nome = "Fulano da Silva";

Console.WriteLine(cliente1.nome);
Console.WriteLine(cliente3.nome);

Console.WriteLine("Saldo: " + cliente1.saldo);



