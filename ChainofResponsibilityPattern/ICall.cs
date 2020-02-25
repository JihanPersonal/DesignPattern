using System;

namespace CallCenter
{
    public enum CallStatus { New, Processing, Accomplished }
    public interface ICall
    {
        int CallID { set; get; }
        CallStatus Status { set; get; }
    }
}