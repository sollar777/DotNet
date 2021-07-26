
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //exercicio1();
            //exercicio2();
            //exercicio3();
        }


        private static void exercicio1()
        {
            using (var contexto = new Models.AppDbContext())
            {

                var resultado = contexto.Autores
                                        .Include(l => l.Livros)
                                        .ThenInclude(e => e.Editor);

                foreach (var item in resultado)
                {
                    Console.WriteLine(item.Nome);
                    foreach (var item2 in item.Livros)
                    {
                        Console.WriteLine($"\t{item2.Titulo} - {item2.AnoLancamento} - {item2.Editor.Nome}");
                    }
                }

                Console.ReadKey();
            }
        }

        private static void exercicio2()
        {
            using (var contexto = new Models.AppDbContext())
            {

                var resultado = contexto.Livros
                                         .Include(a => a.Autor)
                                         .Where(lv => lv.AnoLancamento > 1920);

                foreach (var item in resultado)
                {
                    Console.WriteLine($"\t{item.Titulo} - {item.Autor.Nome} - {item.Autor.Email}");
                }

                Console.ReadKey();
            }
        }

        private static void exercicio3()
        {
            using (var contexto = new Models.AppDbContext())
            {

                var resultado = contexto.Livros
                                         .Include(a => a.Autor)
                                         .ThenInclude(b => b.Biografia).ToList();

                foreach (var item in resultado)
                {
                    Console.WriteLine($"\t{item.Titulo} - {item.Autor.Nome} - {item.Autor.Biografia.Nacionalidade}");
                   
                }



                Console.ReadKey();
            }

        }
    }
}
