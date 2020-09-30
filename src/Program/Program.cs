using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact contact = new Contact("Gms");

            // Crear la lista de contactos
            Phonebook phonebook = new Phonebook(contact);

            // Agregar contactos a la lista
            phonebook.AddContact("pepe");

            Message msg = new Message("Gms", "pepe");

            // Enviar un correo a algunos contactos


            // Enviar un WhatsApp a algunos contactos
            const string accountSid = "AC52493b284c82ba2c6b196ef82e412576";
            const string authToken = "f027e9b15f3777950cdb0179f159a35d";
            IMessageChannel wppChannel = new WhatsAppMessageChanel(accountSid, authToken);
            wppChannel.Send(msg);

            // Enviar un SMS a algunos contactos
        }
    }
}
