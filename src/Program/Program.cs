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
            phonebook.AddContact("Gms", null, "+59898185861");

            // Enviar un correo a algunos contactos


            // Enviar un WhatsApp a algunos contactos
            Message wppMsg = new Message("Gms", "+59896011626");
            wppMsg.Text = "Mensaje de prueba2";

            const string accountSid = "AC52493b284c82ba2c6b196ef82e412576";
            const string authToken = "";
            IMessageChannel wppChannel = new WhatsAppMessageChanel(accountSid, authToken);

            phonebook.SendMessage(wppChannel, wppMsg, new string[]{ "Gms" });

            // Enviar un SMS a algunos contactos
        }
    }
}
