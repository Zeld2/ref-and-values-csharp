using static System.Console;

Pessoa p1 = new Pessoa();

p1.Nome = "Matheus";
p1.Idade = 24;
p1.EnderecoPessoa = new Endereco()
{
Logradouro= "Rua Teste",
Numero= 100,
Cidade= "Bauru",
CEP= "000000"
};

WriteLine("Fim");