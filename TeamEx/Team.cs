using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamEx
{
    public class Team
    {
        public string name;
        public int memberCnt = 0;
        public int maxMember;
        public int minAge;
        public int maxAge;
        public Member[] members;

        public Team(string name, int maxMember, int minAge, int maxAge)
        {
            this.name = name;
            this.maxMember = maxMember;
            this.minAge = minAge;
            this.maxAge = maxAge;

            members = new Member[maxMember];
        }

        public void AddMember(Member m)
        {
            members[memberCnt] = m;
            memberCnt += 1;
        }

        public bool CheckQualification(Member m)
        {
            return (m.Age >= minAge && m.Age <= maxAge);
        }
    }
}
