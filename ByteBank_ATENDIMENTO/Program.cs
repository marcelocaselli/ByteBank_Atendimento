using ByteBank_ATENDIMENTO.ByteBank.Modelos.Conta;
using ByteBank_ATENDIMENTO.ByteBank.Util;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Boas Vindas ao ByteBank Atendimento.");

//TestaArrayInt();
//TestaBuscarPalavra();



static class ObjetoEstatico
{
    static int _valor = 0;

    static public void AtribuirValor(int valor)
    {
        _valor = valor;
    }

    static public int RetornarValor()
    {
        return _valor;
    }
}

public class Objeto
{
    int _valor = 0;

    public void AtribuirValor(int valor)
    {
        _valor = valor;
    }

    public int RetornarValor()
    {
        return _valor;
    }
}

void TesteObjetos()
{
    Objeto o1 = new Objeto();
    Console.WriteLine(o1.MetodoRetornaInteiro());
    Objeto o2 = new Objeto();
    Console.WriteLine(o2.MetodoRetornaInteiro());

    ObjetoEstatico.MetodoRetornaInteiro
}

void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do Array {idades.Length}");

    int acumulador = 0;

    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"Indice [{i}] = {idade}");
        acumulador += idade;
    }

    int media = acumulador / idades.Length;
    Console.WriteLine($"Média de idades = {media}");
}

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];
    
    for ( int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1}ª Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.WriteLine("Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}.");
            break;
        }
    }



}

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

//TestaMediana(amostra);

void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double []) array.Clone();
    Array.Sort(numerosOrdenados);
    //[1,8] [5,9] [6,9] [7,1] [10]

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
                                      (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}

void TestaArrayDeContasCorrentes()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));

}

TestaArrayDeContasCorrentes();

Array