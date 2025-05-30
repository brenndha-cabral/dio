using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sintaxe.Models
{
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public decimal Money { get; set; }
        public DateTime today { get; set; }
        public bool Work { get; set; }

        public void Presentation()
        {
            Console.WriteLine($"Olá, meu nome é {Name}, tenho {Age} anos de idade, tenho {Height} de altura, hoje ({today.ToString("dd/MM/yyyy")}) estudei muito, recebo {Money} por mês e se eu quero trabalhar como programadora? {Work}!");
        }
    }
}