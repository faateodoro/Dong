using System;

namespace Dong
{
    public class Musica
    {
        // deixar sets privados: Done
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome da música não pode ser vazio ou nulo.");
                }
                _nome = value; 
            }
        }

        private string _genero;

        public string Genero
        {
            get { return _genero; }
            private set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O gênero não pode ser vazio ou nulo.");
                }
                _genero = value; 
            }
        }

        private bool _ehSingle;

        public bool EhSingle
        {
            get { return _ehSingle; }
            private set { _ehSingle = value; }
        }

        private DateTime _dataLancamento;

        public DateTime DataLancamento
        {
            get { return _dataLancamento; }
            private set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("A data de lançamento não pode ser nula.");
                }
                _dataLancamento = value; 
            }
        }

        public Musica(string nome, string genero, DateTime dataLancamento, bool ehSingle)
        {
            Nome = nome;
            Genero = genero;
            DataLancamento = dataLancamento;
            EhSingle = ehSingle;
        }

        public override bool Equals(object obj)
        {
            var musica = obj as Musica;
            return musica.Nome == Nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome);
        }
    }
}
