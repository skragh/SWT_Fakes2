using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorProj;

namespace Door.Tests
{
    class FakeDoor:IDoor
    {
        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }
    }

    class FakeValidation: IUserValidation
    {
        public bool ValidateEntryRequest(int id)
        {
            throw new NotImplementedException();
        }
    }

    class FakeEntryNotification: IEntryNotification
    {
        public void NotifyEntryGranted(int id)
        {
            throw new NotImplementedException();
        }

        public void NotifyEntryDenied(int id)
        {
            throw new NotImplementedException();
        }
    }

    class FakeAlarm:IAlarm
    {
        public void RaiseAlarm()
        {
            throw new NotImplementedException();
        }
    }
}
