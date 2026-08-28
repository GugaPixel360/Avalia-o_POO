class PlayList
{
    private List<Musica> musicas;

    private string? nomemusica;

    public string NomeMusica
    {
        get { return nomemusica; }
        set { nomemusica = value; }
    } 

    public List<Musica> Musicas
    {
        get { return musicas; }
        set { musicas = value; }
    }

    public PlayList(string nomeMusica)
    {
        this.nomemusica = nomeMusica;
        this.musicas = new List<Musica>();
    }
}   
