using Microsoft.EntityFrameworkCore;
using Prosegur.GAP.Domain.Seedwork;
using Prosegur.GAP.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.Repository.UnitofWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private GAPDBContext _context;

        public UnitOfWork(GAPDBContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public async Task BeginTransactionAsync()
        {
            await _context.Database.BeginTransactionAsync();
        }

        #region Save Changes
        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        #endregion


    }
}
