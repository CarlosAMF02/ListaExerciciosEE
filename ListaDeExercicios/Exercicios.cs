// Exercício 1

Console.Write("Digite o valor de A: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Digite o valor de B: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Digite o valor de C: ");
double c = double.Parse(Console.ReadLine());

Console.WriteLine($"Área do trângulo tendo A como base e C por altura: {(a * c) / 2}");
Console.WriteLine($"Área do círculo de raio C: {(Math.PI * Math.Pow(c, 2)).ToString("F")}");
Console.WriteLine($"Área do trapézio que tem A e B como bases e C por altura: {((a + b) * c) / 2}");
Console.WriteLine($"Área do quadrado que tem lado B: {Math.Pow(b, 2)}");
Console.WriteLine($"Área do retângulo que tem lados A e B: {a * b}");

// Exercício 2

Console.Write("Digite o valor de A: ");
int a2 = int.Parse(Console.ReadLine());

Console.Write("Digite o valor de B: ");
int b2 = int.Parse(Console.ReadLine());

bool multiplos = false;

if (a2 > b2)
{
    multiplos = a2 % b2 == 0 ? true : false;
}
else if (b2 > a2)
{
    multiplos = b2 % a2 == 0 ? true : false;
}
else
{
    multiplos = true;
}

if (multiplos)
{
    Console.WriteLine("São múltiplos");
}
else
{
    Console.WriteLine("Não são múltiplos");
}

// Exercício 3

Console.Write("Digite a estimativa otimista (em horas): ");
int oti = int.Parse(Console.ReadLine());

Console.Write("Digite a estimativa pessimista (em horas): ");
int pes = int.Parse(Console.ReadLine());

Console.Write("Digite a estimativa mais provável (em horas): ");
int pro = int.Parse(Console.ReadLine());

double pert = (oti + pes + (4 * pro)) / 6;

Console.WriteLine($"PERT = {pert}");

// Exercício 4

Console.Write("Digite a nota do aluno: ");
double nota = double.Parse(Console.ReadLine());

if (nota >= 7) Console.WriteLine("Aprovado");
else if (nota < 7 && nota >= 4) Console.WriteLine("Em recuperação");
else Console.WriteLine("Reprovado");

// Exercício 5

Console.Write("Digite um número inteiro de 1 a 3: ");
int numero = int.Parse(Console.ReadLine());

switch (numero)
{
    case 1:
        Console.WriteLine("Bom dia");
        break;
    case 2:
        Console.WriteLine("Boa tarde");
        break;
    case 3:
        Console.WriteLine("Boa noite");
        break;
    default:
        Console.WriteLine("Número inválido");
        break;
}

// Exercício 6

Console.Write("Digite o número que deseja calcular o fatorial: ");
int numero2, numero3 = int.Parse(Console.ReadLine());
numero2 = numero3;
int fatorial = 1;

while (numero3 != 1)
{
    if (numero3 == 0) break;
    fatorial *= numero3;
    numero3--;
}

Console.WriteLine($"O fatorial de {numero2} é {fatorial}");

// Exercício 7

Console.Write("Digite o número desejado (inteiro): ");
int numeroDesejado = int.Parse(Console.ReadLine());

if (numeroDesejado <= 0) Console.WriteLine("Número inválido");

int contador = 0;

while (numeroDesejado > 0)
{
    numeroDesejado--;
    contador++;
    Console.WriteLine($"{contador} {Math.Pow(contador, 2)} {Math.Pow(contador, 3)}");
}

// Exercício 8

int cha = 0;
int chi = 0;
int qui = 0;
int nul = 0;


Console.WriteLine("Opções de Voto: ");
Console.WriteLine("1. Candidato Chaves");
Console.WriteLine("2. Candidato Chiquinha");
Console.WriteLine("3. Candidato Quico");
Console.WriteLine("4. Nulo/Branco"); 
Console.WriteLine("5. Encerrar a votação");
while (true)
{
    Console.Write("Entre com seu voto: ");
    int opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Você votou no Candidato Chaves");
            cha++;
            break;
        case 2:
            Console.WriteLine("Você votou na Candidato Chiquinha");
            chi++;
            break;
        case 3:
            Console.WriteLine("Você votou no Candidato Quico");
            qui++;
            break;
        case 4:
            Console.WriteLine("Você votou Nulo/Branco");
            nul++;
            break;
        case 5:
            Console.WriteLine("Votação Encerrada");
            Console.WriteLine($"Candidato Chaves: {cha} votos");
            Console.WriteLine($"Candidato Chiquinha: {chi} votos");
            Console.WriteLine($"Candidato Quico: {qui} votos");
            Console.WriteLine($"Nulo/Branco: {nul} votos");

            double totalVotos = cha + chi + qui + nul;

            Console.WriteLine($"Porcentagem de votos Nulos: {(nul/ totalVotos)*10} %");
            Console.WriteLine($"Porcentagem de votos Brancos: {(nul / totalVotos)*10} %");

            List<int> apuracaoVotos = new List<int> { cha, chi, qui };
            int maisVotado = apuracaoVotos.Max();

            int repeticoes = 0; 
            string ganhador = "";

            if(maisVotado == cha)
            {
                repeticoes++;
                ganhador += "Chaves ";
            } 
            if (maisVotado == chi)
            {
                repeticoes++;
                ganhador += "Chiquinha ";
            }
            if (maisVotado == qui)
            {
                repeticoes++;
                ganhador += "Quico ";
            }

            if (repeticoes == 1) Console.WriteLine($"O ganhador foi {ganhador}");
            else Console.WriteLine($"Houve um empate! O ganhadores foram {ganhador}");

            break;
        default:
            Console.WriteLine("Opção Inválida");
            Console.ReadKey();
            break;
    }
    if (opcao == 5) break;
}

// RM87204
// Carlos Alberto Mascarenhas Ferreira
