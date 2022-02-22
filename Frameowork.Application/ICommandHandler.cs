namespace Frameowork.Application
{
    public interface ICommandHandler<T>
    {
        void Handler(T command);
    }
}