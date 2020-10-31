using System;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Framework
{
    public class BorrowItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public string ItemType { get; set; }
        public DateTime Borrowdate { get; set; }
        public double DueCharge { get; set; }

    }
}
