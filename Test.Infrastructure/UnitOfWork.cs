using Test.Domain.Interfaces;
using Test.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

        public IUserRepo Users { get; private set; }

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Users = new UserRepo(_context);
        }

        public UnitOfWork(ApplicationContext context, IUserRepo paramUserRepo)
        {
            _context = context;
            Users = paramUserRepo;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
