﻿using System;

namespace Frameowork.Core.EventHandling
{
    public class BaseEvent : IEvent
    {
        public Guid EventId { get; protected set; }
    }
}
