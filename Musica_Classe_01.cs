class Musica
{
    private string titulo;
    private string artista;
    private int duracaoSegundos;

    public string Titulo
    {
        get { return titulo; }
        set { 
            if (value == "")
            {
                Console.WriteLine("Título inválido! Campo vazio");
                return;
            }
            
            titulo = value; }
    }

    public string Artista
    {
        get { return artista; }
        set { 
            if (value == "")
            {
                Console.WriteLine("Artista inválido! Campo vazio");
                return;
            }
            
            artista = value; }
    }

    public int DuracaoSegundos
    {
        get { return duracaoSegundos; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Duração inválida! A música deve ter mais de 0 segundos.");
                return;
            }
            duracaoSegundos = value;
        }
    }

    public Musica(string titulo, string artista, int duracaoSegundos)
    {
        this.titulo = titulo;
        this.artista = artista;
        this.DuracaoSegundos = duracaoSegundos;
    }

    public override string ToString()
    {
        int minutos = duracaoSegundos / 60;
        int segundos = duracaoSegundos;
        return $"Música: {titulo} | Artista: {artista} | Duração: {minutos}:{segundos} :)";
    }

    public void IsLonga()
    {
        if (duracaoSegundos > 300)
        {
            Console.WriteLine("A música é longa. :)");
        }
        else
        {
            Console.WriteLine("A música não é longa. :(");
        }
    }
}
