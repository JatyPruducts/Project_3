using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomber_3
{
    public class main : List<Machines>
    {
        public void TakeCars()
        {
            var sorter =
                from machines in this
                where machines.crashies == true
                select machines;
            
            Console.WriteLine($"Список участников ДТП: ");

            foreach (var machines in sorter)
            {
                Console.Write(machines.number + " ");
            }
        }
    }
}