﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frankenwiki.Domain.EventHandlers
{
    public interface IDomainEventHandler<TEvent> where TEvent: IDomainEvent
    {
        void Handle(TEvent domainEvent);
    }
}