using System.Text;

namespace Nick_Chapsas;
public class String_Optimization
{
    private const string password = "Pas12345@!#";
    public void StringOptimization()
    {
        /// <summary>
        /// Optimization of string :
        /// </summary>

        ////Using String : Immutable type so it is slow
        var firstThree = password.Substring(0,3);
        var length = password.Length -3;
        for (var i = 0; i < length; i++)
        {
            firstThree += "*";
        }
        Console.WriteLine(firstThree);

        ////Using StringBuilder : Faster than string
        var stringbuilder = new StringBuilder(firstThree);
        for (var i = 0; i < length; i++)
        {
            stringbuilder.Append("*");
        }
        Console.WriteLine(stringbuilder);

        ////Using String with constructor:  Much Faster than String or StringBuilder
        var asteriks = new string('*',length);
        System.Console.WriteLine(firstThree + asteriks);

        ////Using string.Create() : Most efficient way but not use in real application
        string.Create(password.Length,password,(span,value)=>
        {
            value.AsSpan().CopyTo(span); // spanga barcha elementlarni ko'chiradi
            span[3..].Fill('*'); // 3 inchi indexdan uyog'iga * cha bilan to'ldiradi.
        });
    }
}