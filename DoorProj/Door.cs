using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorProj
{
    interface IDoor
    {
        public void Close();
        public void Open();
    }

    interface IUserValidation
    {
        public bool ValidateEntryRequest(int id);
    }

    interface IEntryNotification
    {
        public void NotifyEntryGranted(int id);
        public void NotifyEntryDenied(int id);
    }

    interface IAlarm
    {
        public void RaiseAlarm();
    }
}
