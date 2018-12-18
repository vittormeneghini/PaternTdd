using Microsoft.EntityFrameworkCore;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Context
{
    public class MysqlContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql("SERVER=[pokeawesome.com.br];PORT=[22];DataBase=teste;Uid=[awesomemaster];Pwd=[cafu30114783];");
        }
    }
}
