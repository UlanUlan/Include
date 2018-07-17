using ConsoleApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApplication1
{
    class Program
    {
        //private static MCSEntities db = new MCSEntities();
        static void Main(string[] args)
        {
            MCSEntities db = new MCSEntities();
            db.Database.Log = Console.Write;


            //явная загрузка

            TablesModel model = db.TablesModels.Find(1);

            foreach (var source in db.TablesSNPrefixes.Where(w=>w.intModelID==model.intModelID))
            {
                model.TablesSNPrefixes.Add(source);
            }

            db.Entry(model).Collection(c => c.TablesSNPrefixes).Load();


            return;

            //Ленивая (отложенная) загрузка

            foreach (var tablesModel in db.TablesModels.Take(5))
            {
                Console.WriteLine(tablesModel.strName);
                foreach (var tablesSnPrefix in tablesModel.TablesSNPrefixes)
                {
                    Console.WriteLine("   -" + tablesSnPrefix.strPrefix);
                }
            }

            return;

            //Прямая загрузка

            List<newEquipment> equipments = db.newEquipments.Include(d => d.TablesLocation).Include(d => d.TablesManufacturer).Include(d => d.TablesModel.TablesSNPrefixes).ToList();

            Console.WriteLine("-----------------------------------");

            foreach (var newEquipment in equipments)
            {
                Console.WriteLine(newEquipment.intGarageRoom);
                foreach (var pref in newEquipment.TablesModel.TablesSNPrefixes)
                {
                    Console.WriteLine("->" + pref.strPrefix);
                }
            }
            Console.WriteLine("--------------------------------------------");
        }
    }
}
