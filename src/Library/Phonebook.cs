using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }

        public void AddContact(string name, string userName = null, string phone = null)
        {
            Contact newContact = new Contact(name);
            newContact.UserName = userName;
            newContact.Phone = phone;
            this.persons.Add(newContact);
        }
        public void RemoveContact(string[] name)
        {
            List<Contact> rContacts;
            rContacts = Search(name);
            foreach(Contact rContact in rContacts)
            {
                persons.Remove(rContact);
            }
        }
        public void SendMessage(IMessageChannel channel, IMessage message, string[] names)
        {
            List<Contact> destinatarios = Search(names);
            foreach(Contact destinatario in destinatarios)
            {
                IMessage msg = new Message(this.Owner.Name, destinatario.Name);
                channel.Send(message, destinatario);
            }
        }
    }
}