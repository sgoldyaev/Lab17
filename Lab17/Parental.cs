using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    public class Parental
    {
        public int ParentalId { get; set; }
        public string FIO_rod { get; set; }
        public string Phone { get; set;}
        // public string ChildrenID { get; set;}

        //многие
        public virtual ICollection<TroopList> TroopLists { get; set; }
        public Parental()
        {
            TroopLists = new List<TroopList>();
        }

        //один ко многим
        //public int ChildrenId { get; set; }
        //public virtual Children Children { get; set; }
        ////public int? ChildrenId { get; set; }
        ////public Children Childre { get; set; }
        //public int TroopListId { get; set; }
        //public virtual TroopList TroopList { get; set; }



    }
}
