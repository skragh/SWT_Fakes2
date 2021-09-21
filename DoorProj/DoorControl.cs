using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorProj
{
    class DoorControl
    {
        IDoor _door;
        IUserValidation _userValidation;
        IEntryNotification _entryNotification;
        IAlarm _alarm;
        DoorControl(IDoor door, IUserValidation val, IEntryNotification en, IAlarm alarm)
        {
            _door = door;
            _userValidation = val;
            _entryNotification = en;
            _alarm = alarm;
        }

        public void RequestEntryID(int id)
        {
            if (_userValidation.ValidateEntryRequest(id) == true)
            {
                _door.Open();
                _entryNotification.NotifyEntryGranted(id);
            }
            else if(_userValidation.ValidateEntryRequest(id) == false)
            {
                _entryNotification.NotifyEntryDenied(id);
            }
            else
            {
                _alarm.RaiseAlarm();
            }
        }

        public void DoorOpened()
        {
            _door.Close();
        }

        public void DoorClosed()
        {
            //Door has been closed, set alarm and stuff I guess..?
        }

    }
}
