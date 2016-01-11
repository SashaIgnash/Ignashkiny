using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS
{
    class Orders
    {
        public int ID { get; set; }
        public int Number { get; set; }

        public Products product { get; set; }
    }
}
