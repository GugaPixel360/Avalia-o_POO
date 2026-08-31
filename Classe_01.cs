class PlayList
{
    private List<Musica> musicas;

    private string? nomePlaylist;

    public string NomePlaylist
    {
        get { return nomePlaylist; }
        set { nomePlaylist = value; }
    } 

    public List<Musica> Musicas
    {
        get { return musicas; }
        set { musicas = value; }
    }

    public PlayList(string nomePlaylist)
    {
        this.nomePlaylist = nomePlaylist;
        this.musicas = new List<Musica>();
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public override string ToString()
    {
        return $"PlayList: {nomePlaylist} | Músicas: {musicas}";
    }
}   
