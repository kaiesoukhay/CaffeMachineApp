using DataAcess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly MachineAppContext _context;
        private readonly ILogger _logger;


        public UnitOfWork(MachineAppContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");

        }
        public void Dispose()
        {
            _context.Dispose();
        }

        async Task IUnitOfWork.CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
