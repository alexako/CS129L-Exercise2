using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamEx
{
    public class Member
    {
        public string name;
        private int age;

        public Member(string name, int age)
        {
            this.name = name;
            this.Age = age;
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
    }
}
