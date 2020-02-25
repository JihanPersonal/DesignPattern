using System;

namespace CallCenter
{
    class Call : ICall
    {
        public Call(int id)
        {
            CallID = id;
            Status = CallStatus.New;
        }
        public int CallID
        {
            get; set;
        }
        public CallStatus Status
        {
            get; set;
        }
    }
}