using _04_UniversitySystem.Models;
namespace UniversitySystem;

internal class Program
{
    static void Main(string[] args)
    {
        List<Human> people = new List<Human>();

        people.Add(new Rector("Kamran Babayev", 50, 10, 25, "Baki University"));
        people.Add(new Teacher("Ali Məmmədov", 35, "Informatika", 10, 2000m));
        people.Add(new Student("Vəli Əliyev", 20, "AB123", "Computer Science", 85m));


        foreach (Human person in people)
        {
            person.Info();
            Console.WriteLine();
        }
    }
}