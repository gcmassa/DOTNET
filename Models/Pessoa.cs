using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNET.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        
        //public string NomeRepresentanteLegalDaPessoaFisica { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
            //Console.WriteLine($"Olá, meu nome é " + 
            // $"{Nome}, e tenho {Idade} anos");
            //Console.WriteLine($"Olá, meu nome é {Nome}\n e tenho {Idade} anos");
        }
    }
}