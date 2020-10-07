using CAD_Prof.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CAD_Prof.Context
{
    public class Contexto : DbContext
    {
        public DbSet<ProfessorModel> Professores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}