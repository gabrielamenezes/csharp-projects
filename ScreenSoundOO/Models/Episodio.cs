using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSoundOO.Models
{
    internal class Episodio
    {
        public Episodio(int ordem, string titulo, int duracao) {
            this.Titulo = titulo;
            this.Duracao = duracao;
            this.Ordem = ordem;
        }
        public int Duracao { get;  }
        public int Ordem { get; }
        public string Titulo { get; }
        public string Resumo =>  $"O podcast {Ordem} - {Titulo} tem duração de {Duracao} e conta com o(s) convidado(s) -  {string.Join(',', listaDeConvidados)}";
        private List<string> listaDeConvidados = new List<string>();

        public void AdicionarConvidados(string convidado)
        {
            listaDeConvidados.Add(convidado);
        }
    }
}
