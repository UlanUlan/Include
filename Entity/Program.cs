using Entity.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq;

namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            Exmpl02();
        }
        public static void Exmpl01()
        {
            mcs db = new mcs();

            db.Database.Log = (s => System.Diagnostics.Debug.WriteLine(s));

            int i = 0;

            foreach (var accesTab in db.AccessTab)
            {
                i++;
                Console.WriteLine(accesTab.strTabName);
                foreach (var item in accesTab.AccessUser)
                {
                    Console.WriteLine("\t--> "+item.intUserId);i++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(i);

           // List<AccessTab> tabs = db.AccessTab.Include(c => c.AccessUser).ToList();
        }

        public static void Exmpl02()
        {
            mcs db = new mcs();

            //Загрузка одной вкладки

            AccessTab tab = db.AccessTab.Where(w => w.intTabID == 1).FirstOrDefault();

            addExmpl02(tab);

            //Загрузка связанные данные с этой вкладки

            // db.Entry(tab).Collection(c => c.AccessUser).Load();

            //Console.WriteLine(tab.strTabName);
            //foreach (var user in tab.AccessUser)
            //{
            //    Console.WriteLine("\t--> " +user.intUserId);
            //}
        }

        private static void addExmpl02(AccessTab tab)
        {
            Console.WriteLine(tab.strTabName);
            //foreach (var user in tab.AccessUser)
            //{
            //    Console.WriteLine("\t--> " + user.intUserId);
            //}
        }
    }
}
