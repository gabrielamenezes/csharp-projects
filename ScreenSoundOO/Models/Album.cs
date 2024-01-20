using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSoundOO
{
    internal class Album
    {
        public Album(string nome) {
            Nome = nome;
        }
        public string Nome { get; }
        public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);
        private List<Musica> musicas = new List<Musica>();

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }
        public void ExibirMusicas()
        {
            int contador = 1;
            Console.WriteLine("\nMúsicas do Album \n");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"Faixa {contador} - {musica.Nome} ");
                contador++; 
            }
            Console.WriteLine($"Duração: {DuracaoTotal}");
        }
    }
}
