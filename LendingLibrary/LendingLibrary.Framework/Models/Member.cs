using System;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Framework.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public GroupName GetGroupName { get; set; }
    }
}
