using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSoundOO
{
    internal class Musica
    {

        // propriedades no c# - Pascal Case
        public string Nome { get; set; }
        public string Artista { get; set; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public Genero Genero { get; set; }
        public string Descricao => $"A música {Nome} pertende ao artista {Artista}";

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Música: {Nome}");
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Duração: {Duracao}");
            string mensagem = Disponivel ? "Disponível na plataforma: Sim" : "Disponível na plataforma: Não";
            Console.WriteLine(mensagem);
            Console.Write(Descricao + "\n");
        }
    }
}
