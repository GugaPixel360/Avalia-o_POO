class Jogo
{
    private string nome;
    private string plataforma;
    private int ano;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Plataforma
    {
        get { return plataforma; }
        set { plataforma = value; }
    }

    public int Ano
    {
        get { return ano; }
        set { ano = value; }
    }

    public Jogo(string nome, string plataforma, int ano)
    {
        this.nome = nome;
        this.plataforma = plataforma;
        this.ano = ano;
    }

    public override string ToString()
    {
        return $"Jogo: {nome} | Plataforma: {plataforma} | Ano: {ano}";
    }
}