using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionsManager
{
    class Item
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public System.Collections.Generic.List<Property> Properties { get; set; }

        public Item()
        {
            Properties = new System.Collections.Generic.List<Property>();
        }
    }
}
