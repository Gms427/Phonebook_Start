using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño

            // Crear la lista de contactos

            // Agregar contactos a la lista

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos

            // Enviar un SMS a algunos contactos

            string consumerKey = "CONSUMERKEY";
            string consumerKeySecret = "CONSUMERKEYSECRET";
            string accessToken = "ACCESSTOKEN";
            string accessTokenSecret = "ACCESSTOKENSECRET";
            TwitterChannel twitter = new TwitterChannel(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Message messageg = new Message("PooUcu", "809185528457338880");
            messageg.Text = "Hola! Todo bien?";
            twitter.Send(messageg);
        }
    }
}
