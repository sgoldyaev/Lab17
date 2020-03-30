using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            LabContext db = new LabContext();
            db.Database.CreateIfNotExists();

            var parentalss = db.Parentals.ToList();

            foreach (var parental in parentalss)
            {
                Console.WriteLine("1. Название: {0}\n" +
                    "2. : FIO {1}\n",
                    "3. : {2}\n",
                    parental.Phone, parental.FIO_rod,  parental.Phone);

                Console.WriteLine();
            }

            Console.WriteLine("End");

            Console.Read();
        }
    }
}
