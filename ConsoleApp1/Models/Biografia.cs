using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Biografia
    {
        public int BiografiaId { get; set; }

        public string BiografiaAutor { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Nacionalidade { get; set; }

        public int AutorId { get; set; }

        public Autor Autor { get; set; }
    }
}
