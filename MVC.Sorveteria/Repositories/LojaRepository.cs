using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using MVC.Sorveteria.Models;
using MVC.Sorveteria.Persistencia;

namespace MVC.Sorveteria.Repositories
{
    public class LojaRepository : ILojaRepository
    {
        private SorveteriaContext _context;

        public LojaRepository(SorveteriaContext context)
        {
            _context = context;
        }

        public void Atualizar(Loja loja)
        {
            _context.Entry(loja).State = EntityState.Modified;
        }

        public IList<Loja> BuscarPor(Expression<Func<Loja, bool>> filtro)
        {
            return _context.Lojas.Where(filtro).ToList();
        }

        public void Cadastrar(Loja loja)
        {
            _context.Lojas.Add(loja);
        }

        public IList<Loja> Listar()
        {
            return _context.Lojas.ToList();
        }

        public void Remover(int codigo)
        {
            var loja = _context.Lojas.Find(codigo);
            _context.Lojas.Remove(loja);
        }
    }
}