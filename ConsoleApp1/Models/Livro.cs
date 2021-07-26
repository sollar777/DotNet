using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Livro
    {
        public int LivroId { get; set; }

        public string Titulo { get; set; }

        public string Tipo { get; set; }

        public int AnoLancamento { get; set; }


        public Autor Autor { get; set; }

        public int AutorId { get; set; }


        public Editor Editor { get; set; }

        public override string ToString()
        {
            return Titulo;
        }
    }
}
