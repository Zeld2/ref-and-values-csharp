using static System.Console;

class Aula2
{

    static void Demo1()
    {
        int a = 5;
        Adicionar20(ref a);
        WriteLine($"O valor de a é {a}");
    }
    static void Adicionar20(ref int a)
    {
        a += 20;
    }

    static void AlterarNome(string[] nomes, string nome, string nomeNovo)
    {
        for (var i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nome)
            {
                nomes[i] = nomeNovo;
            }
        }
    }

    static ref string LocalizarNome(string[] nomes, string nome)
    {
        for (var i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nome)
            {
                return ref nomes[i];
            }
        }
        throw new Exception("Nome não encontrado");
    }

    static void Main()
    {
        var nomes = new string[] { "José", "Maria", "Ricardo", "Matheus", "Alice" };

        WriteLine(@$"A lista de nomes é:
    {string.Join(", \n", nomes)}
    ");

        WriteLine("");
        WriteLine("Digite o nome a ser alterado:");
        string nome = ReadLine();
        WriteLine("Digite o novo nome:");
        string nomeNovo = ReadLine();
        WriteLine("");

        ref var nomeAchado = ref LocalizarNome(nomes, nome);

        if (!string.IsNullOrEmpty(nomeAchado))
        {
            nomeAchado = nomeNovo;
            WriteLine(@$"A lista de nomes alterada é:
    {string.Join(", \n", nomes)}
    ");

        }
        else
        {
            WriteLine("Nome não encontrado.");
        }
    }
}