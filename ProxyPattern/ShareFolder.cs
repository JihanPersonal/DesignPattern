using System;

namespace ProxyPattern
{
    class ShareFolder : IshareFolder
    {
        public string GetShareResource()
        {
            return "This is the real resource";
        }
    }
}