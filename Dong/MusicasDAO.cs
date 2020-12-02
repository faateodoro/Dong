using System;
using System.Collections.Generic;
using System.Text;

namespace Dong
{
    public class MusicasDAO
    {
        public MusicasDAO()
        {
            DB = new Dictionary<Artista, IList<Musica>>();
        }

        private IDictionary<Artista, IList<Musica>> DB { get; set; }


        public void Adicionar(Artista artista, Musica musica)
        {
            // fazer a verificação do artista: Done
            // adicionar música na lista: Done

            if (DB.ContainsKey(artista))
            {
                if (DB[artista].Contains(musica))
                {
                    throw new ArgumentException("Essa música já existe na lista.");
                }
                DB[artista].Add(musica);
            }
            else
            {
                var listaMusica = new List<Musica>();
                listaMusica.Add(musica);
                DB.Add(artista, listaMusica);
            }
        }
    }
}
