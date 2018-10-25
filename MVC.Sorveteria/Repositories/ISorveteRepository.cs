using MVC.Sorveteria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Sorveteria.Repositories
{
    public interface ISorveteRepository
    {
        void Cadastrar(Sorvete sorvete);
        void Atualizar(Sorvete sorvete);
        void Remover(int codigo);
        IList<Sorvete> Listar();
        IList<Sorvete> BuscarPor(Expression<Func<Sorvete, bool>> filtro);
    }
}
