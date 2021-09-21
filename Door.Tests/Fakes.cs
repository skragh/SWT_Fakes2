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
        }

        public void Open()
        {
        }
    }

    class MockDoor:IDoor
    {
        public int CloseCalled=0;
        public int OpenCalled = 0;
        public void Close()
        {
            CloseCalled++;
        }

        public void Open()
        {
            OpenCalled++;
        }
    }

    class FakeValidation: IUserValidation
    {
        public bool ValidationValue { set; get; }
        public bool ValidateEntryRequest(int id)
        {
            return ValidationValue;
        }
    }

    class FakeEntryNotification: IEntryNotification
    {

        public void NotifyEntryGranted(int id)
        {
        }

        public void NotifyEntryDenied(int id)
        {
        }
    }

    class MockEntryNotification: IEntryNotification
    {
        public int NotifyEntryGrantedCalled { get; set; }
        public int NotifyEntryDeniedCalled { get; set; }
        public void NotifyEntryGranted(int id)
        {
            NotifyEntryGrantedCalled++;
        }

        public void NotifyEntryDenied(int id)
        {
            NotifyEntryDeniedCalled++;
        }
    }

    class FakeAlarm:IAlarm
    {
        public void RaiseAlarm()
        {
        }
    }

    class MockAlarm:IAlarm
    {
        public int RaiseAlarmCalled { get; set; }
        public void RaiseAlarm()
        {
            RaiseAlarmCalled++;
        }
    }
}

