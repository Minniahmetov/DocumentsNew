using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Collections;

namespace DocumentsNew
{
    public class Doc
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string DocType { get; set; }

        public TablePart tablePart { get; set; }
    }

    public class TablePart : IEnumerable
    {
        [Key]
        [ForeignKey("Doc")]
        public int Id { get; set; }
        public Doc Doc { get; set; }
        public virtual ICollection<TablePartString> TablePartStrings { get; set; }
        public TablePart()
        {
            TablePartStrings = new List<TablePartString>();
        }

        public IEnumerator GetEnumerator()
        {
            return TablePartStrings.GetEnumerator();
        }

    }

    public class TablePartString
    {
        public int Id { get; set; }
        public int GoodId { get; set; }
        public int Quantity { get; set; }
        public int Balance { get; set; }
        public int? TablePartId { get; set; }
        public virtual TablePart TablePart { get; set; }
    }
    

    public class Good
    {
        public int Id { get; set; }
        public string GoodName { get; set; }
    }

    public class GoodBalnce

    {
        public int Id { get; set; }
        public int GoodId { get; set; }
        public int DocId { get; set; }
        public DateTime DateTime { get; set; }
        public int openingBalance { get; set; }
        public int Flow { get; set; }
        public int Cancellaton { get; set; }
        public int Balance { get; set; }

    }
}
