using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact contact = new Contact("Test");

            // Crear la lista de contactos
            Phonebook phonebook = new Phonebook(contact);

            // Agregar contactos a la lista
            phonebook.AddContact("Gms", null, "+11111111111");

            // Enviar un correo a algunos contactos


            // Enviar un WhatsApp a algunos contactos
            Message wppMsg = new Message("Gms", "+11111111111");
            wppMsg.Text = "Mensaje de prueba2";

            const string accountSid = "";
            const string authToken = "";
            IMessageChannel wppChannel = new WhatsAppMessageChanel(accountSid, authToken);

            phonebook.SendMessage(wppChannel, wppMsg, new string[]{ "Gms" });

            // Enviar un SMS a algunos contactos
        }
    }
}
