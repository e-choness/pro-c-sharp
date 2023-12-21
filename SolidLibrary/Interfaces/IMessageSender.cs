namespace SolidLibrary.Interfaces
{
    public interface IMessageSender
    {
        void SendMessage(IVendor retailer, string message);
    }
}