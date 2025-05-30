using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>{
        public MyContext CreateDbContext (string[] args){
            //Usado para criar as migrações
            var connectionString = "Server=localhost;Port=5433;Database=pjs;User Id=admin;Password=1234";
            //Produção
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseNpgsql(connectionString);
            return new MyContext (optionsBuilder.Options);
        }
    }
}