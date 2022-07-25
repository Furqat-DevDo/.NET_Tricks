namespace Nick_Chapsas;
/// <summary>
/// Endi zip methodiga 3 ta parametr berish mumkin
/// </summary>
public class Zip
{
    public void Zipping()
    {
        /// <summary>
        /// Endi zip methodiga 3 ta parametr berish mumkin
        /// </summary>
        
        var fullnames = new [] {"Abduvosiqov Furqat","Abdullayev Bobur","Saidov Farux"};
        var ages = new []{26,25,27};
        var experienceinYear= new []{5,7,10};
        var zip = fullnames.Zip(ages,experienceinYear);

        foreach(var item in zip)
        {
            Console.WriteLine(item);
        }
    }
}