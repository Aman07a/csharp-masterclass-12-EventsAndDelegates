using System;
using System.Collections.Generic;
using System.Drawing;

namespace _12___EventsAndDelegates
{
    internal class Program
    {
        // // Properties
        // public string text;
        // public Color backColor;
        // public int sizeW, sizeH;

        // // Delegate
        // private delegate void OnClickDelegate();

        // private OnClickDelegate onClick;

        // void SendButtonClick()
        // {
        //     // Network.Connect();
        //     // Network.SendMessage();
        //     // DisplayMessageSentDialog();
        // }

        // // A method called Filter that takes a string
        // static bool Filter(string s)
        // {
        //     // Return whether the string s contains the letter 'i'
        //     // The Contains method will return a bool which we will return as well
        //     return s.Contains("i");
        // }

        // // Defining a delegate type called FilterDelegate that takes a person object and returns a bool
        // public delegate bool FilterDelegate(Person p);

        // // A method to display the list of people that passes the filter condition.
        // // (Returns true)
        // // This method will take a title to be displayed, the list of people.
        // // And a filter delegate
        // static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        // {
        //     // Print the title
        //     Console.WriteLine(title);

        //     foreach (Person p in people)
        //     {
        //         // Check if this person passes the filter
        //         if (filter(p))
        //         {
        //             // Print the person's name and age
        //             Console.WriteLine("{0}, {1} years old.", p.Name, p.Age);
        //         }
        //     }
        // }

        // //==========FILTERS====================
        // static bool IsMinor(Person p)
        // {
        //     return p.Age < 18;
        // }

        // static bool IsAdult(Person p)
        // {
        //     return p.Age >= 18;
        // }

        // static bool IsSenior(Person p)
        // {
        //     return p.Age >= 65;
        // }

        static void Main(string[] args)
        {
            // SendButton.OnClick = SendButtonClick;

            // if (IsMouseHovering && IsLeftClickPressed)
            // {
            //     SendButton.OnClick();
            // }

            // // List of names
            // List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli" };

            // Console.WriteLine("----before----");
            // // Print the names before the remove all method
            // foreach (string name in names)
            // {
            //     Console.WriteLine(name);
            // }

            // // Calling RemoveAll and passing a method Filter we created
            // names.RemoveAll(Filter);

            // Console.WriteLine("----after----");
            // // Print the names after the remove all method
            // foreach (string name in names)
            // {
            //     Console.WriteLine(name);
            // }

            // // Create 4 Person objects
            // Person p1 = new Person() { Name = "Aiden", Age = 41 };
            // Person p2 = new Person() { Name = "Sif", Age = 69 };
            // Person p3 = new Person() { Name = "Walter", Age = 12 };
            // Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            // // Add the objects to a list called people
            // List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            // DisplayPeople("Kids: ", people, IsMinor);
            // DisplayPeople("Adults: ", people, IsAdult);
            // DisplayPeople("Seniors: ", people, IsSenior);
        }
    }
}
