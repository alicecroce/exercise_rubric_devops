using static System.Reflection.Metadata.BlobBuilder;
using System.Collections.Generic;

namespace exercise_rubric_devops
{
    internal class Rubric
    {
        List<Contact> contacts;//dichiarazione lista di contatti dentro la rubrica

        public Rubric()
        {
            contacts = new List<Contact>();//inizializzazione lista
        }

        //metodo per aggiungere un contatto
        public void AddContact(Contact contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException(nameof(contact), "Inserisci dei caratteri validi.");
            }
            contacts.Add(contact);
        }


        //metodo di eliminazione contatto per nome
        public void RemoveContact(string name)
        {
            contacts.RemoveAll(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }


        //metodo per la ricerca di un contatto per nome
        public Contact SearchContactByName(string name)
        {
            foreach (Contact contact in contacts)
            {
                if (contact.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                return contact;
                }
            }
            Console.WriteLine($"Contatto \"{name}\" non trovato.");
            return null;
        }

        //metodo per mostrare i contatti
        public void ShowContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("Nessun contatto presente nella rubrica.");
                return;
            }

            foreach (var contact in contacts)
            {
                Console.WriteLine($"Nome: {contact.Name}, Cognome: {contact.LastName}");
            }
        }





    }
}
