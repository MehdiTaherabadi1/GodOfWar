using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameowork.Core.EventHandling
{
    public interface IEvent
    {
        Guid EventId { get; }
    }
}
