﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSoundOO.Models
{
    internal class Banda
    {
        public Banda(string nome) {
            Nome = nome;
        }
        private List<Album> albums = new List<Album>();
        public string Nome { get; }
        public void AdicionarAlbum(Album album)
        {
            albums.Add(album);
        }

        public void ExibirDiscografia()
        {
            Console.WriteLine($"Discografia da banda {Nome}");
            foreach (Album album in albums)
            {
                Console.WriteLine($"Álbum: {album.Nome} - ({album.DuracaoTotal})");
            }
        }
    }
}
