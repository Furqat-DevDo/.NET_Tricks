namespace Nick_Chapsas
{
    public class LINQ_Tricks
    {
        public void ExampleMethod()
        {
        /// <summary>
        /// New way to get max age or min age from class
        /// </summary>

        var family = new []
        {
            new Familymember("Furqat",27),
            new Familymember("Bobur",26),
            new Familymember ("Azamat",21)
        };
        // // Old way
        var youngest = family.OrderBy(x => x.Age).First();
        var Oldest = family.OrderByDescending(x => x.Age).First();
        // //new way
        var young = family.MinBy(x=>x.Age);
        var old = family.MaxBy(p=>p.Age);

        /// <summary>
        /// ^ index operatori orqali Elementni olish imkoniyati.
        /// </summary>

        var names = new [] { "Furqat","Bobur","Aziz","Azamat","Leyla"};
        var name = names.ElementAtOrDefault(^3);
        Console.WriteLine(name);

        /// <summary>
        /// Bir nechta elementni o'tkazib qolganini tanlash:
        /// </summary>

        // // Old WAy
        var slice = names.Skip(2).Take(2); // Result : Aziz Azamat
        // //New way
        var newway = names.Take(2..4); // Result : Aziz Azamat
        // // using index operator
        var LastThree = names.Take(^3..);// Result :Aziz Azamat Leyla
        }
    }

}
internal class Familymember
{
    public string Name;
    public int Age;

    public Familymember(string v1, int v2)
    {
        Name = v1;
        Age = v2;
    }
}
