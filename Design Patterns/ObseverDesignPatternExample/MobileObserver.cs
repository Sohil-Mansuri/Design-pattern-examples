using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObseverDesignPatternExample
{
    internal class MobileObserver : INotificationObserver
    {
        private readonly string _userID;
        public MobileObserver(string userID)
        {
            _userID = userID;

        }
        public void Update()
        {
            SendMsg(_userID);
        }

        private void SendMsg(string userID)
        {
            Console.WriteLine($"Sent Message to the user {userID}");
        }
    }
}
