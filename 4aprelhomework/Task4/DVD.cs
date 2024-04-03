using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4aprelhomework.Task4
{
    internal class DVD : ILibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int AvailableCopies { get; set; }

        public void CheckOut()
        {

            if (AvailableCopies > 0)
            {
                AvailableCopies--;
                Console.WriteLine("satildi");
            }
            else
            {
                Console.WriteLine("Elde yoxdur");
            }
        }

        public void Return()
        {
            AvailableCopies++;
            Console.WriteLine("geri qaytarildi");
        }
    }
}
