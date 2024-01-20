using ScreenSoundOO.Models;

Podcast podcast = new Podcast("Mark", "TI");
Episodio ep1 = new Episodio(1, "técnicas de facilitação", 45);
ep1.AdicionarConvidados("Diogo");
Episodio ep2 = new Episodio(2, "técnicas de invasão", 45);
ep2.AdicionarConvidados("Gabriela");
Episodio ep3 = new Episodio(3, "técnicas de desenvolvimento", 45);
ep3.AdicionarConvidados("Lucas");

podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
Console.WriteLine(ep1.Resumo);
podcast.ExibirDetalhes();