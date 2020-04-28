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
        public IbankLoginContext(DbContextOptions<IbankLoginContext> options)
            : base(options)
        {
        }

        public DbSet<IbankLogin.Models.Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente
                {
                    ClienteId = 1,
                    Nome = "Antonio",
                    Agencia = 1234,
                    Conta = 987654,
                    Senha = 1122
                },
                new Cliente
                {
                    ClienteId = 2,
                    Nome = "Maria",
                    Agencia = 1234,
                    Conta = 456789,
                    Senha = 2233
                },
                new Cliente
                {
                    ClienteId = 3,
                    Nome = "Ana",
                    Agencia = 1234,
                    Conta = 111145,
                    Senha = 4875
                }
            );
        }

    }
}
