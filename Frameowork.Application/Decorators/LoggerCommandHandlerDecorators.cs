using System.Diagnostics;

namespace Frameowork.Application.Decorators
{
    public class LoggerCommandHandlerDecorators<T> : ICommandHandler<T>
    {
        private readonly ICommandHandler<T> _targetHandler;

        public LoggerCommandHandlerDecorators(ICommandHandler<T> targetHandler)
        {
            _targetHandler = targetHandler;
        }

        public void Handler(T command)
        {
            Debug.Write("***********");
            _targetHandler.Handler(command);
            Debug.Write("***********");
        }
    }
}