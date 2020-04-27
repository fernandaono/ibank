using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IbankLogin.Models;

namespace IbankLogin.Data
{
    public class IbankLoginContext : DbContext
    {
        public IbankLoginContext (DbContextOptions<IbankLoginContext> options)
            : base(options)
        {
        }

        public DbSet<IbankLogin.Models.Cliente> Cliente { get; set; }
    }
}
