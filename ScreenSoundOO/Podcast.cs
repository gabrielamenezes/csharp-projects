using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSoundOO
{
    internal class Podcast
    {
        public Podcast(string host, string nome) 
        { 
            this.Host = host;
            this.Nome = nome;
        }
        public string Host { get;}
        public string Nome { get;}
        private List<Episodio> TotalEpisodios = new List<Episodio>();

        public void AdicionarEpisodio(Episodio episodio)
        {
            TotalEpisodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Podcast {Nome} é hosteado por {Host}");
            foreach (Episodio episodio in TotalEpisodios)
            {
                Console.WriteLine($"Episódio número {episodio.Ordem} - {episodio.Titulo} - Duração: {episodio.Duracao} \n");
            }
            Console.WriteLine($"Total de episódios: {TotalEpisodios.Count()}");
        }
    }
}
