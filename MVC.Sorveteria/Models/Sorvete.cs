using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Sorveteria.Models
{
    public class Sorvete
    {
        public int SorveteId { get; set; }
        public string Nome { get; set; }
        public string Sabor { get; set; }
        public DateTime DataValidade { get; set; }
        public bool Casquinha { get; set; }

        //Relacionamento
        public Loja Loja { get; set; }
        public int LojaId { get; set; }
    }
}