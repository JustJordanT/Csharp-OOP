using System.Collections.Generic;

namespace Constructors
{
    public partial class customer
    {
        public int Id;
        public string Name;
        public List<order> Orders; 

        public customer()
        {
            var order = new order();
        }
        
        public customer(int id)
            : this()
        {
            this.Id = id;
        }

        public customer(int id, string name)
            : this(id) //This is not a best practice.
        {
            this.Name = name;
        }
    }
}