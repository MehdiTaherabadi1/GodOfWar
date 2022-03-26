using Frameowork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOM.Application;

namespace UOM.Interface.Facade.Contracts
{
    public interface IDimensionFacade : IFacadeService
    {
        Guid Create(CreateDimensionCommand command);
    }
}
