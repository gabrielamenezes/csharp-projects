using ScreenSoundOO;

Album AlbumArcticMonkeys =  new Album();
AlbumArcticMonkeys.Nome = "AM";
Musica musica1 = new Musica();
musica1.Artista = "Arctic Monkeys";
musica1.Nome = "Do I Wanna Know?";
musica1.Duracao = 120;
musica1.Disponivel = true;

Musica musica2 = new Musica();
musica2.Artista = "Arctic Monkeys";
musica2.Nome = "R U Mine?";
musica2.Duracao = 120;
musica2.Disponivel = true;

Musica musica3 = new Musica();
musica3.Artista = "Arctic Monkeys";
musica3.Nome = "I wanna be yours";
musica3.Duracao = 120;
musica3.Disponivel = true;

Musica musica4 = new Musica();
musica4.Artista = "Arctic Monkeys";
musica4.Nome = "Why'd You Only Call Me When You're High?";
musica4.Duracao = 180;
musica4.Disponivel = true;

Musica musica5 = new Musica();
musica5.Artista = "Arctic Monkeys";
musica5.Nome = "Arabella";
musica5.Duracao = 180;
musica5.Disponivel = true;

AlbumArcticMonkeys.AdicionarMusica(musica1);
AlbumArcticMonkeys.AdicionarMusica(musica2);
AlbumArcticMonkeys.AdicionarMusica(musica3);
AlbumArcticMonkeys.AdicionarMusica(musica4);
AlbumArcticMonkeys.AdicionarMusica(musica5);

Banda arcticMonkeys = new Banda();
arcticMonkeys.Nome = "Arctic Monkeys";
arcticMonkeys.AdicionarAlbum(AlbumArcticMonkeys);
arcticMonkeys.ExibirDiscografia();