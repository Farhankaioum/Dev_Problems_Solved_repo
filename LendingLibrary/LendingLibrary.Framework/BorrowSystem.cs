using LendingLibrary.Framework.Interfaces;
using LendingLibrary.Framework.Models;
using LendingLibrary.Framework.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary.Framework
{
    public class BorrowSystem : IBorrowItem
    {
        private const double DueCharge = 2.50;
        private const int HighestCharge = 20;

        Member member = new Member();
        MockMember mockMember = new MockMember();

        public List<BorrowItem> BorrowRecordeditem = new List<BorrowItem>();

        public BorrowSystem()
        {
            BorrowRecordeditem.Add(new BorrowItem { Id = 1, UserId = 1, ItemType = "Book", Borrowdate = DateTime.Now, DueCharge = 0, ItemId = 1 });
        }


        public int BorrowItem(int memberId, BorrowItemRecord borrowItemRecord)
        {
            var existingMember = mockMember.members.Find(m => m.Id == memberId);

            if(existingMember != null)
            {
                if(borrowItemRecord.BorrowItems.Count <= 4)
                {
                    var due = CalculateChargeCount(memberId);

                    if(due < HighestCharge)
                    {
                        foreach(var item in borrowItemRecord.BorrowItems)
                        {


                            item.Id = BorrowRecordeditem.Count + 1;
                            BorrowRecordeditem.Add(item);
                        }

                        return 1;
                    }
                    else
                    {
                        // sending email
                    }
                }

            }

            return 0;
        }

        // for calculation member due charge
        public double CalculateChargeCount(int memberId)
        {
            var findMember = mockMember.members.Find(m => m.Id == memberId);

            if(member == null)
            {
                throw new Exception("You provide wrong member id");
            }

            var existingBorrowItem = BorrowRecordeditem.FindAll(c => c.UserId == memberId);

            double bookDueTotal = 0, movieDueTotal = 0, videoGamesDueTotal = 0;

            foreach(var item in existingBorrowItem)
            {
                var borrowDate = item.Borrowdate.ToString("yyyy-MM-dd");
                var day = item.Borrowdate.Day;
                var dayCount = DateTime.Now.Day - day;

                if(item.ItemType.ToUpper() == "BOOK")
                {
                    if (dayCount >= 4)
                        bookDueTotal += DueCharge * (dayCount - 4);
                }
                else if(item.ItemType.ToUpper() == "MOVIE")
                {
                    if (dayCount >= 2)
                        movieDueTotal += DueCharge * (dayCount - 2);
                }
                else
                {
                    if (dayCount >= 2)
                        videoGamesDueTotal += DueCharge * (dayCount - 2);
                }
            }

            var total = bookDueTotal + movieDueTotal + videoGamesDueTotal;


            return total;
        }

        public async Task SendEmail(int memberId, string subject, string message)
        {
            var member = mockMember.members.Find(m => m.Id == memberId);

            var mailRequest = new MailRequest
            {
                ToEmail = member.Email,
                Subject = subject,
                Body = message
            };

            await SendEmailAsync(mailRequest);
        }

        // Sending email
        private async Task SendEmailAsync(MailRequest mailRequest)
        {
            var _mailSettings = new MailSettings();

            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress(_mailSettings.Mail, _mailSettings.DisplayName);
            message.To.Add(new MailAddress(mailRequest.ToEmail));
            message.Subject = mailRequest.Subject;
           
            message.IsBodyHtml = false;
            message.Body = mailRequest.Body;
            smtp.Port = _mailSettings.Port;
            smtp.Host = _mailSettings.Host;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(_mailSettings.Mail, _mailSettings.Password);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            await smtp.SendMailAsync(message);

        }

        public void UpdateUser(int memberId, int userId)
        {
            throw new NotImplementedException();
        }

        public bool RenewBorrowItem(int memberId, int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
