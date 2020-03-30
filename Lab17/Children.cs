using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Lab17
{
    public class Children
    {

        public int ChildrenId { get; set; }
        public string FIO_reb { get; set; }
        public string Birthdate { get; set; }


        public virtual ICollection<TroopList> TroopLists { get; set; }
        public virtual ICollection<Parental> Parentals { get; set; }

        public Children()
        {
            TroopLists = new List<TroopList>();
            Parentals = new List<Parental>();
        }
        public int TroopListId { get; set; }
        public virtual TroopList TroopList { get; set; }

        //public int? TroopListId { get; set; }
        //public TroopList TroopList { get; set; }

        //[Key, ForeignKey("CardChildren")]
        //public CardChildren CardChildren { get; set; }
        //один ко многим
        //public int TroopListId { get; set; }
        //public virtual TroopList TroopList { get; set; }
        //один к одному
        //public CardChildren CardChilde { get; set; }
        //public ICollection<Children> Childrenss { get; set; }
        //public Children()
        //{
        //    Childrenss = new List<Children>();
        //}
    }
}
