using System;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Framework.Settings
{
    public class MailSettings
    {
        public string Mail { get; set; } = "your mail address here";
        public string DisplayName { get; set; } = "Mail";
        public string Password { get; set; } = "your email password here";
        public string Host { get; set; } = "smtp.gmail.com";
        public int Port { get; set; } = 587;
    }
}
