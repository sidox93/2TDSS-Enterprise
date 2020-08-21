using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula03.Web.Models
{
    public class Carro
    {
        [HiddenInput]
        public int Codigo { get; set; }

        public string Modelo { get; set; }

        public int Ano { get; set; }

        [Display(Name = "Data de Entrada")]
        [DataType(DataType.Date)]
        public DateTime DataEntrada { get; set; }

        public bool Novo { get; set; }

        [Display(Name = "Combustível")]
        public Combustivel Combustivel { get; set; }
    }
}
