using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    internal class DBScolaire :DbContext
    {
        public DBScolaire() :base("connectioniage")
        { }
        public DbSet<Classe> Classe { get; set; }
        public DbSet<Etudiant> Etudiant { get; set; }
    }
}
