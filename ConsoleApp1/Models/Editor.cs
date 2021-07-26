using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Editor
    {
        public int EditorId { get; set; }

        public string Nome { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}
