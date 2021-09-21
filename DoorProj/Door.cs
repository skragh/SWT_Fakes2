using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorProj
{
    public interface IDoor
    {
        public void Close();
        public void Open();
    }

    public interface IUserValidation
    {
        public bool ValidateEntryRequest(int id);
    }

    public interface IEntryNotification
    {
        public void NotifyEntryGranted(int id);
        public void NotifyEntryDenied(int id);
    }

    public interface IAlarm
    {
        public void RaiseAlarm();
    }
}
