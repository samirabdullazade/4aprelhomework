using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4aprelhomework.Task4
{
    public interface ILibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int AvailableCopies { get; set; }
        public void CheckOut();
        public void Return();
    }
}
