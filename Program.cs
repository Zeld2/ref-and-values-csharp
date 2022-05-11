using System.Collections.Generic;
using static System.Console;
using ref_and_values;

public class Program

{

    static void Demo7()
    {
                List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa(){Nome = "Matheus"},
            new Pessoa(){Nome = "Cleber"},
            new Pessoa(){Nome = "João"},
            new Pessoa(){Nome = "Pedro"},
            new Pessoa(){Nome = "Drauzio"},
            new Pessoa(){Nome = "Julio"},
            new Pessoa(){Nome = "Bernardo"}
        };

        WriteLine("Digite a pessoa que gostaria de localizar na lista:");
        var nome = ReadLine();
        var pessoa = new Pessoa(){Nome = nome};
        var encontrado = EncontrarPessoa(pessoas, pessoa);
        if(encontrado){
            WriteLine("Pessoa localizada.");
        }else{WriteLine("Pessoa não localizada.");}
    }
    static void Demo6()
    {
        var numeros = new int[] { 0, 2, 4, 6, 8 };
        WriteLine("Digite o número que gostaria de encontrar");
        var numeroProcurado = int.Parse(ReadLine());
        var idxEncontrado = EncontrarNumero(numeros, numeroProcurado);

        if (idxEncontrado >= 0)
        {
            WriteLine($"O número digitado está na posição {idxEncontrado}");
        }
        else { WriteLine("O número não foi encontrado"); }
    }

    static void Demo5()
    {
        var pares = new int[] { 0, 2, 4, 6, 8 };

        MudarParaImpar(pares);

        Write($"Os impares são: {string.Join(",", pares)}");
    }
    static void Demo4()
    {
        string nome = "Matheus";

        nome = TrocarNome(nome, "MatD");

        WriteLine($"O novo nome é {nome}");
    }

    static void Demo3()
    {
        StructPessoa p1 = new StructPessoa
        {
            Documento = "1234",
            Idade = 30,
            Nome = "Matheus"
        };
        var p2 = p1;

        p1 = TrocarNome(p1, "João");

        WriteLine($@"
        O nome de p1 é : {p1.Nome}
        O nome de p2 é : {p2.Nome}
        ");
    }

    static void Demo2()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Matheus";
        p1.Idade = 24;
        p1.Documento = "1234";

        Pessoa p2 = p1.Clone();

        TrocarNome(p1, "MatD");

        WriteLine($@"
        O nome de p1 é : {p1.Nome}
        O nome de p2 é : {p2.Nome}
        ");


    }
    static void Demo1()
    {
        int a = 2;
        a = Adicionar20(a);

        WriteLine($"O valor da variável a é {a}");
    }
    static int Adicionar20(int x)
    {
        return x + 20;
    }

    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }

    static StructPessoa TrocarNome(StructPessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
        return p1;
    }

    static string TrocarNome(string nome, string nomeNovo)
    {
        nome = nomeNovo;
        return nome;
    }

    static void MudarParaImpar(int[] pares)
    {
        for (var i = 0; i < pares.Length; i++)
        {
            pares[i] = pares[i] + 1;
        }
    }

    static int EncontrarNumero(int[] numeros, int numero)
    {
        for (var i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == numero)
                return i;
        }
        return -1;
    }

    static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
    {
        foreach (var item in pessoas)
        {
            if (item.Nome == pessoa.Nome)
            {
                return true;
            }
        }
        return false;
    }
    
        static bool EncontrarPessoa(List<StructPessoa> pessoas, StructPessoa pessoa)
    {
        foreach (var item in pessoas)
        {
            if (item.Equals(pessoa))
            {
                return true;
            }
        }
        return false;
    }
    public static void Main()
    {
        List<StructPessoa> pessoas = new List<StructPessoa>()
        {
            new StructPessoa(){Nome = "Matheus"},
            new StructPessoa(){Nome = "Cleber"},
            new StructPessoa(){Nome = "João"},
            new StructPessoa(){Nome = "Pedro"},
            new StructPessoa(){Nome = "Drauzio"},
            new StructPessoa(){Nome = "Julio"},
            new StructPessoa(){Nome = "Bernardo"}
        };

        WriteLine("Digite a pessoa que gostaria de localizar na lista:");
        var nome = ReadLine();
        var pessoa = new StructPessoa(){Nome = nome};
        var encontrado = EncontrarPessoa(pessoas, pessoa);
        if(encontrado){
            WriteLine("Pessoa localizada.");
        }else{WriteLine("Pessoa não localizada.");}

    }
}