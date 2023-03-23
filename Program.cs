using System;
using System.Collections.Generic;

class Program
{
    static List<Contact> contacts = new List<Contact>();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Our Contact Management Software");
        Console.WriteLine("Please Choose Your Option:\n");
        Console.WriteLine("1. Add Contact");
        Console.WriteLine("2. Get All contact");
        Console.WriteLine("3. Delete Contact");
        Console.WriteLine("4. Update Phone Number");
        Console.WriteLine("0. Exit\n");

        while (true)
        {
            Console.Write("Enter your option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddContact();
                    break;
                case 2:
                    GetAllContacts();
                    break;
                case 3:
                    DeleteContact();
                    break;
                case 4:
                    UpdatePhoneNumber();
                    break;
                case 0:
                    Console.WriteLine("Thank you for using our software!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.\n");
                    break;
            }
        }
    }

    static void AddContact()
    {
        Console.Write("\nEnter contact name: ");
        string name = Console.ReadLine();

        Console.Write("Enter contact phone number: ");
        string phoneNumber = Console.ReadLine();

        contacts.Add(new Contact(name, phoneNumber));

        Console.WriteLine("\nContact added successfully!\n");
    }

    static void GetAllContacts()
    {
        Console.WriteLine("\nAll contacts:\n");

        foreach (Contact contact in contacts)
        {
            Console.WriteLine(contact.Name + " - " + contact.PhoneNumber);
        }

        Console.WriteLine();
    }

    static void DeleteContact()
    {
        Console.Write("\nEnter contact name to delete: ");
        string name = Console.ReadLine();

        int removedCount = contacts.RemoveAll(contact => contact.Name == name);

        if (removedCount > 0)
        {
            Console.WriteLine("\nContact deleted successfully!\n");
        }
        else
        {
            Console.WriteLine("\nContact not found.\n");
        }
    }

    static void UpdatePhoneNumber()
    {
        Console.Write("\nEnter contact name to update phone number: ");
        string name = Console.ReadLine();

        Contact contact = contacts.Find(c => c.Name == name);

        if (contact == null)
        {
            Console.WriteLine("\nContact not found.\n");
            return;
        }

        Console.Write("Enter new phone number: ");
        string newPhoneNumber = Console.ReadLine();

        contact.PhoneNumber = newPhoneNumber;

        Console.WriteLine("\nPhone number updated successfully!\n");
    }
}

class Contact
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public Contact(string name, string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;
    }
}
