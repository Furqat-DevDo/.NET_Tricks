using System;
namespace Nick_Chapsas;

public static class Program
{
    public static void Main()
    {
        var someobject = new NullGuardian();
        //if(someobject.Null is null) 
        //ArgumentNullException.ThrowIfNull(someobject.Null);
        System.Console.WriteLine(someobject.Null); 
        // NullGuard.Fody package o'zi nullga tekshirib Nulldan himoya qiladi.
    }
}