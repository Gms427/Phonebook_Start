using WhatsAppApiUCU;

namespace Library
{
    public class WhatsAppMessageChanel : IMessageChannel
    {
        private WhatsAppApi whatsAppApi;

        public WhatsAppMessageChanel(string accountSid, string authToken)
        {
            this.whatsAppApi = new WhatsAppApi(accountSid, authToken);
        }
        public void Send(Message message)
        {
            this.whatsAppApi.Send(message.To, message.Text);
        }
    }
}