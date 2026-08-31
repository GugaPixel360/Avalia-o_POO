class Jogo
{
    private string nome;
    private string plataforma;
    private int ano;

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

    public string Plataforma
    {
        get { return plataforma; }
        set { 
            if (value != "PC" && value != "PlayStation" && value != "Xbox" && value != "Nintendo Switch")
            {
                Console.WriteLine("Plataforma inválida! Aceitamos apenas: PC, PlayStation, Xbox e Nintendo Switch.");
                return;
            }
            
            plataforma = value; }
    }

    public int Ano
    {
        get { return ano; }
        set { 
            if (value < 1958)
            {
                Console.WriteLine("Só aceitamos jogos eletrônicos, e o 1° foi em 1958, bota outra data ai.");
                return;
            }

            if (value > 2026)
            {
                Console.WriteLine("Vai botar o GTA 10 é? Pod não man.");
                return;
            }
            
            ano = value; }
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

    public void IsOld()
    {
        if (ano < 2000)
        {
            Console.WriteLine("O jogo é antigo. :)");
        }
        else
        {
            Console.WriteLine("O jogo não é antigo. :)");
        }
    }
}
