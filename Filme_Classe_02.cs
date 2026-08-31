class Filme
{
    private string nome;
    private string genero;
    private int duracao;

    public string Nome
    {
        get { return nome; }
        set { 
            if (nome == "")
            {
                Console.WriteLine("Nome inválido! Campo vazio");
                return;
            }
            
            nome = value; }
    }

    public string Genero
    {
        get { return genero; }
        set { 
            if (genero == "")
            {
                Console.WriteLine("Gênero inválido! Campo vazio");
                return;
            }
            
            genero = value; }
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

    public void IsLongo()
    {
        if (duracao > 120)
        {
            Console.WriteLine("O filme é longo. :)");
        }
        else
        {
            Console.WriteLine("O filme não é longo. :)");
        }
    }
} 