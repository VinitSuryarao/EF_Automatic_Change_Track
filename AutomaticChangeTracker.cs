using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Database_First
{
    class AutomaticChangeTracker
    {

        static void Main(string[] args)
        {
            MDSEntities db = new MDSEntities(); // Object of context class

            // Add Record to Entity
            tb_Client addClient = new tb_Client() { n_ClientNo = 6, s_ClientCode = "CUS0505" };
            db.tb_Client.Add(addClient);

            foreach (var item in db.ChangeTracker.Entries<tb_Client>())
            {
                Console.WriteLine(item.State);
            }

            // Update Record to Entity
            tb_Client updateClient = db.tb_Client.Find(3);
            if (updateClient != null)
            {
                updateClient.s_ClientName = "CCN0501";
            }

            foreach (var item in db.ChangeTracker.Entries<tb_Client>())
            {
                Console.WriteLine(item.State);
            }

            // Delete Record to Entity
            tb_Client deleteClient = db.tb_Client.Find(3);
            if (deleteClient != null)
            {
                db.tb_Client.Remove(deleteClient);
            }

            foreach (var item in db.ChangeTracker.Entries<tb_Client>())
            {
                Console.WriteLine(item.State);
            }


            Console.ReadLine();

        }
    }
}
