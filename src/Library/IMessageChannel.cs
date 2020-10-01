namespace Library
{
    public interface IMessageChannel
    {
         void Send(IMessage message, Contact contact);
    }
}