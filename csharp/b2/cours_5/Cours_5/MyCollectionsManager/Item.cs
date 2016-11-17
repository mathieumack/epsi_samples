using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionsManager
{
    public abstract class Item : IEditable
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public List<Property> Properties { get; set; }

        public Item()
        {
            Properties = new System.Collections.Generic.List<Property>();
        }

        public abstract void ShowDetail();

        public abstract void Edit(string nom, double test);
        
        public int toto()
        {
            // TODO : Coder cette fonction plus tard
            // HACK : Coder cette fonction plus tard
            return 0;
        }
    }
}
