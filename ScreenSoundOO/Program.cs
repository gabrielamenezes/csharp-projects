using ScreenSoundOO;

Banda arcticMonkeys = new Banda("Arctic Monkeys");

Album AlbumArcticMonkeys =  new Album("AM");
Musica musica1 = new Musica(arcticMonkeys, "Do I Wanna Know?");
musica1.Duracao = 120;
musica1.Disponivel = false;

Musica musica2 = new Musica(arcticMonkeys, "R U Mine?") { Duracao=120, Disponivel = true };


Musica musica3 = new Musica(arcticMonkeys, "I wanna be yours") { Duracao = 120, Disponivel = true };


Musica musica4 = new Musica(arcticMonkeys, "Why'd You Only Call Me When You're High?")
{
    Duracao = 180,
    Disponivel = true,
};


Musica musica5 = new Musica(arcticMonkeys, "Arabella")
{
    Duracao = 180,
    Disponivel = true,
};


AlbumArcticMonkeys.AdicionarMusica(musica1);
AlbumArcticMonkeys.AdicionarMusica(musica2);
AlbumArcticMonkeys.AdicionarMusica(musica3);
AlbumArcticMonkeys.AdicionarMusica(musica4);
AlbumArcticMonkeys.AdicionarMusica(musica5);


arcticMonkeys.AdicionarAlbum(AlbumArcticMonkeys);
arcticMonkeys.ExibirDiscografia();