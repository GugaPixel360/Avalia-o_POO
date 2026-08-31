Jogo jogo1 = new Jogo("The Legend of Zelda: Breath of the Wild", "Nintendo Switch", 2017);
Console.WriteLine(jogo1.ToString());

Filme filme1 = new Filme("Vingadores: Ultimato", "Marvel", 181);
Console.WriteLine(filme1.ToString());

Musica musica1 = new Musica("Bohemian Rhapsody", "Queen", 354);
Console.WriteLine(musica1.ToString());

filme1.IsLongo();
jogo1.IsOld();
musica1.IsLonga();