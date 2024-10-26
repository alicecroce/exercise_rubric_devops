using static System.Reflection.Metadata.BlobBuilder;

namespace exercise_rubric_devops
{
    internal class Rubric
    {
        List<Contact> contacts;//dichiarazione lista di contatti dentro la rubrica

        public Rubric()
        {
            contacts = new List<Contact>();//inizializzazione lista
        }

        //procedura per aggiungere un contatto
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }


        //procedura di eliminazione contatto per nome
        public void RemoveContact(string name)
        {
            contacts.RemoveAll(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

    }
}
