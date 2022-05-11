namespace ref_and_values
{
    public class Pessoa
    {
    public int Idade {get; set;}

    public string Documento {get; set;}

    public string Nome {get; set;}

    public Pessoa Clone()
    {
        return new Pessoa()
        {
            Documento = this.Documento,
            Idade= this.Idade,
            Nome= this.Nome
        };
    }
    
    }
}