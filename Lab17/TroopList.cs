using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    public class TroopList
    {
        public int TroopListId { get; set; }

        public string NumberRoom { get; set; }
        public string Place { get; set; }
        //один ко многим

        ////многие ко многим
        public virtual ICollection<Parental> Parentals { get; set; }
        //public TroopList()
        //{
        //    Parentals = new List<Parental>();
        //}
    }
}
