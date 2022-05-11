    public struct StructPessoa
    {
    public int Idade {get; set;}

    public string Documento {get; set;}

    public string Nome {get; set;}

    public StructPessoa Clone()
    {
        return new StructPessoa()
        {
            Documento = this.Documento,
            Idade= this.Idade,
            Nome= this.Nome
        };
    }

    }