using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q2
{
    public class Member
    {
        public int MemberID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }

        public Member(int memberID, string lastName, string firstName, string fullName)
        {
            MemberID = memberID;
            LastName = lastName;
            FirstName = firstName;
            FullName = fullName;
        }
    }
}
