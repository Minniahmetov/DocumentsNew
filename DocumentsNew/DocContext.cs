using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DocumentsNew
{
    public class DocContext : DbContext
    {
        public DocContext()
                : base("DbConnection")
        { }

        public DbSet<Doc> Docs { get; set; }
        public DbSet<TablePart> TableParts { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<GoodBalnce> GoodBalnces { get; set; }
        public DbSet<TablePartString> TPSs { get; set; }

    }
}
