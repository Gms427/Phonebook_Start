namespace Library
{
    public class Message: IMessage
    {
        public Message(string from, string to)
        {
            this.From = from;
            this.To = to;
        }

        public string Text { get; set; }

        public string From { get; }

        public string To { get; }
    }
}