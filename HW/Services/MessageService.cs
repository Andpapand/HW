namespace HW.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage() => "Повідомлення з сервісу через IoC";
    }
}
