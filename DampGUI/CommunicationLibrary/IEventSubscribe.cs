﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationLibrary
{
    public interface IEventSubscribe
    {
        void HandleNewChatMessage(string from, string message);
    }
}