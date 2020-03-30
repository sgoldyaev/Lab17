using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    public class LabContext : DbContext
    {
        //public DbSet<Children> Childrens { get; set; }
        public DbSet<Parental> Parentals { get; set; }
        //public DbSet<CardChildren> CardChildrens { get; set; }
        public DbSet<TroopList> TroopListss { get; set; }

        public LabContext() : base("LabContext")
        { }

        static LabContext()
        {
            Database.SetInitializer(new Init());
        }
    }

    public class Init : DropCreateDatabaseAlways<LabContext>
    {
        protected override void Seed(LabContext context)
        {
            var childrens = new List<Parental>
            {
               new Parental {FIO_rod = "ППП"}
            };

            childrens.ForEach(c => context.Parentals.Add(c));
        }
    }
}