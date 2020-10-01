using TwitterUCU;

namespace Library
{
    public class TwitterChannel : IMessageChannel
    {
        private TwitterMessage twitter;
        public TwitterChannel(string consumerKey,string consumerKeySecret, string accessToken, string accessTokenSecret)
        {
            twitter = new TwitterMessage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
        }
        public void Send(IMessage message, Contact contact)
        {
            twitter.SendMessage(message.Text, contact.UserName);
        }
    }
}