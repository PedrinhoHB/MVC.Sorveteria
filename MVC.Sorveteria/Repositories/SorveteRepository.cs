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
    public class SorveteRepository : ISorveteRepository
    {
        private SorveteriaContext _context;

        public SorveteRepository(SorveteriaContext context)
        {
            _context = context;
        }

        public void Atualizar(Sorvete sorvete)
        {
            _context.Entry(sorvete).State = EntityState.Modified;
        }

        public IList<Sorvete> BuscarPor(Expression<Func<Sorvete,bool>> filtro)
        {
            return _context.Sorvetes.Where(filtro).ToList();
        }

        public void Cadastrar(Sorvete sorvete)
        {
            _context.Sorvetes.Add(sorvete);
        }

        public IList<Sorvete> Listar()
        {
            return _context.Sorvetes.ToList();
        }

        public void Remover(int codigo)
        {
            var sorv = _context.Sorvetes.Find(codigo);
            _context.Sorvetes.Remove(sorv);
        }
    }
}