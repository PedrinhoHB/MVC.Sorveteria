using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Sorveteria.Models
{
    public class Loja
    {
        public int LojaId { get; set; }
        public string Nome { get; set; }
        public string Local { get; set; }

        //Relacionamento
        public IList<Sorvete> Sorvetes { get; set; }
    }
}