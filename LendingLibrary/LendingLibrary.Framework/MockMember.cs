using LendingLibrary.Framework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Framework
{
    public class MockMember
    {
        public List<Member> members = new List<Member>();

        public MockMember()
        {
            members.Add(new Member { Id = 1, Name = "ABC", Email="abc@gmail.com", GetGroupName = GroupName.Software });
            members.Add(new Member { Id = 2, Name = "ABC2", Email="abc2@gmail.com", GetGroupName = GroupName.Software });
            members.Add(new Member { Id = 3, Name = "ABC3", Email="abc3@gmail.com", GetGroupName = GroupName.Software });
            members.Add(new Member { Id = 4, Name = "ABC4", Email="abc4@gmail.com", GetGroupName = GroupName.Software });
            members.Add(new Member { Id = 5, Name = "ABC5", Email="abc5@gmail.com", GetGroupName = GroupName.Software });
            members.Add(new Member { Id = 6, Name = "ABC6", Email="abc6@gmail.com", GetGroupName = GroupName.Software });
            members.Add(new Member { Id = 7, Name = "ABC7", Email="abc7@gmail.com", GetGroupName = GroupName.Software });
            members.Add(new Member { Id = 8, Name = "ABC8", Email="abc8@gmail.com", GetGroupName = GroupName.Software });
        }
    }
}
