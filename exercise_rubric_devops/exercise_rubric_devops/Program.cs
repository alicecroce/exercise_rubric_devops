using System;

namespace exercise_rubric_devops
{
    internal class Program
    {
        static void Main()
        {
            Rubric rubric = new Rubric();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Rubrica Contatti ---");
                Console.WriteLine("1. Aggiungi contatto");
                Console.WriteLine("2. Rimuovi contatto");
                Console.WriteLine("3. Cerca contatto");
                Console.WriteLine("4. Mostra tutti i contatti");
                Console.WriteLine("0. Esci");

                Console.Write("Seleziona un'opzione: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Inserisci il nome del contatto: ");
                        string name = Console.ReadLine();
                        Console.Write("Inserisci il cognome del contatto: ");
                        string lastName = Console.ReadLine();
                        rubric.AddContact(new Contact(name, lastName));
                        break;

                    case "2":
                        Console.Write("Inserisci il nome del contatto da rimuovere: ");
                        string nameToRemove = Console.ReadLine();
                        rubric.RemoveContact(nameToRemove);
                        break;

                    case "3":
                        Console.Write("Inserisci il nome del contatto da cercare: ");
                        string nameToSearch = Console.ReadLine();
                        Contact foundContact = rubric.SearchContactByName(nameToSearch);
                        if (foundContact != null)
                        {
                            Console.WriteLine($"Contatto trovato: {foundContact.Name} {foundContact.LastName}");
                        }
                        break;

                    case "4":
                        rubric.ShowContacts();
                        break;

                    case "0":
                        running = false;
                        Console.WriteLine("Chiusura del programma.");
                        break;

                    default:
                        Console.WriteLine("Opzione non valida. Riprova.");
                        break;
                }
            }
        }
    }
}
