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

        public void AddContact(string name)
        {
            Contact newContact = new Contact(name);
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
        public void SendMessage(IMessageChannel channel, string Text, string[] names)
        {
            List<Contact> destinatarios = Search(names);
            foreach(Contact destinatario in destinatarios)
            {
                Message message = new Message(destinatario.Name, Owner.Name);
                message.Text = Text;
                channel.Send(message);
            }
            

        }
    }
}