namespace SolidLibrary.Interfaces
{
    public interface IMessageSender
    {
        void SendMessage(IProduct product, string message);
    }
}