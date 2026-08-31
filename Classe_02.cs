class Filme
{
    private string nome;
    private string genero;
    private int duracao;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Genero
    {
        get { return genero; }
        set { genero = value; }
    }

    public int Duracao
    {
        get { return duracao; }
        set { if (value <= 0)
        {Console.WriteLine("Duração inválida! insira um valor positivo."); return;} 
            else { duracao = value; } }
    }

    public Filme(string nome, string genero, int duracao)
    {
        this.nome = nome;
        this.genero = genero;
        this.duracao = duracao;
    }

    public override string ToString()
    {
        return $"Filme: {nome} | Gênero: {genero} | Duração: {duracao} minutos";
    }
} 