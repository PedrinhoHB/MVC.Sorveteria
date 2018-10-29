using MVC.Sorveteria.Persistencia;
using MVC.Sorveteria.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Sorveteria.Units
{
    public class UnityOfWork : IDisposable
    {
        private SorveteriaContext _context = new SorveteriaContext();

        private ISorveteRepository _sorveteRepository;

        public ISorveteRepository SorveteRepository
        {
            get
            {
                if (_sorveteRepository == null)
                {
                    _sorveteRepository = new SorveteRepository(_context);
                }
                return _sorveteRepository;
            }
            
        }

        private ILojaRepository _lojaRepository;

        public ILojaRepository LojaRepository
        {
            get
            {
                if (_lojaRepository == null)
                {
                    _lojaRepository = new LojaRepository(_context);
                }
                return _lojaRepository;
            }
        }


        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}