using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Frameowork.Application;
using Frameowork.Core;
using Frameowork.Core.EventHandling;
using UOM.Application;
using UOM.Domain.Contracts;
using UOM.Query.Model.Models;
using UOM.Query.Model.Reposiotres;

namespace UOM.Interface.RestApi
{
    public class DimensionsController : ApiController, IGateway
    {
        private readonly ICommandBus _commandBus;
        private readonly IEventListener _eventListener;

        public DimensionsController(ICommandBus commandBus, IEventListener eventListener)
        {
            _commandBus = commandBus;
            _eventListener = eventListener;
        }

        public Guid Post(CreateDimensionCommand dto)
        {
            Guid id = Guid.Empty;
            _eventListener.Subscribe<DimensionCreated>(a =>
            {
                id = a.Id;
            });
            _commandBus.Dispatch(dto);
            return id;
        }
    }
}
