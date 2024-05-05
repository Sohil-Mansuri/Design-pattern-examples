using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObseverDesignPatternExample
{
    internal class EmailObserver : INotificationObserver
    {
        private readonly string _userID;
        public EmailObserver(string userID)
        {
            _userID = userID;
        }

        public void Update()
        {
            SendEmai(_userID);
        }

        private void SendEmai(string userID)
        {
            Console.WriteLine($"Email sent to the {userID}");
        }
    }
}
