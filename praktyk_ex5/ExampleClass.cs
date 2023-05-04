using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs_Ex
{
    abstract class UserInfo
    {
        protected string Name;
        protected byte Age;

        public UserInfo(string Name, byte Age)
        {
            this.Name = Name; this.Age = Age;
        }
        public abstract string ui();
    }
    class UserFamily : UserInfo
    {
        string Family;
        public UserFamily(string Family, string Name, byte Age) : base(Name, Age)
        {
            this.Family = Family;
        }
        public override string ui()
        {
            return Family + " " + Name + ", " + Age;
        }
    }
}
