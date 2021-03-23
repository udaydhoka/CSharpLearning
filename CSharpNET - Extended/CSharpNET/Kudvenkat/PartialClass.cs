using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNET
{
    //here we've used a partial keyword 
    public partial class PartialClass
    {
        // we're declaring two private fileds and two public properties
        private int Id;

        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
