using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab17
{
    public class CardChildren
    {
        //[Key, ForeignKey("Children")]
        public int CardChildrenId { get; set; }
        //public int ChildrenId { get; set; }
        public string Information { get; set; }
        ////один к одному
        //[Required]
        //public Children Children { get; set; }
    }
}