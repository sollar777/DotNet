using System.Collections.Generic;


namespace ConsoleApp1.Models
{
    class Autor
    {
        public int AutorId { get; set;  }

        public string Nome { get; set; }

        public string Email { get; set; }


        public ICollection<Livro> Livros { get; set; }

        public Biografia Biografia { get; set; }
    }
}
