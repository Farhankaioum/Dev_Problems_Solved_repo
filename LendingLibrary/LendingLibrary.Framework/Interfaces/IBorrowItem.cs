using LendingLibrary.Framework.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary.Framework.Interfaces
{
    public interface IBorrowItem
    {
        public int BorrowItem(int memberId, BorrowItemRecord borrowItemRecord);
        public double CalculateChargeCount(int memberId);
        public Task SendEmail(int memberId, string subject, string message);
        public void UpdateUser(int memberId, int userId);
        public bool RenewBorrowItem(int memberId, int itemId);
    }
}
