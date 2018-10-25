using MVC.Sorveteria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Sorveteria.Repositories
{
    public interface ILojaRepository
    {
        void Cadastrar(Loja loja);
        void Atualizar(Loja loja);
        void Remover(int codigo);

        IList<Loja> Listar();
        IList<Loja> BuscarPor(Expression<Func<Loja, bool>>filtro);
    }
}
