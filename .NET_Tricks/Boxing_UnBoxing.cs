using System.Collections;

namespace Nick_Chapsas;
public static class Boxing_UnBoxing
{
    public static void ExampleMethod()
    {
        /// <summary>
        /// Boxing va Unboxing tushunchasi:
        /// </summary>
        int someNumber = 420;
        object boxed = someNumber; // Boxing
        int unboxed = (int)boxed; // UnBoxing

        var arrayofints = Enumerable.Range(42,420).ToArray();
        var arraylist = new ArrayList(arrayofints); // This class also boxing variables but each of them as a individual object !!
        var list = new List<int> (arrayofints); // This also boxing variables but as array !!!
    }
}