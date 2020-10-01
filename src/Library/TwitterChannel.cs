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
        public void Send(Message message)
        {
            twitter.SendMessage(message.Text, message.To);
        }
    }
}