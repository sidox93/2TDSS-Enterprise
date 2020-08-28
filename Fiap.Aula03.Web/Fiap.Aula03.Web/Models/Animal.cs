using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula03.Web.Models
{
    public class Animal
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public Tamanho Tamanho { get; set; }
        public bool Domestico { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Especie { get; set; } //select com algumas opções
    }

    //Implementar o CRUD, sem copiar do outro!! Só vale consultar...

}
