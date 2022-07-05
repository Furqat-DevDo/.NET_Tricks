using System.Reflection;
namespace Nick_Chapsas;
public static  class Reflection_Optimization
{
     private static readonly PropertyInfo CachedProprety = typeof (PublicClass)
        .GetProperty("Lastname",
        BindingFlags.Instance | BindingFlags.NonPublic);
    
        /// <summary>
        /// Reflection bu private fieldlarni,propretylarni  qiymatini olish va ular bilna ishlash:
        /// </summary>

        // Traditional Reflection : Slow
        static string Reflection()
        {
            var someclass = new PublicClass();
            var propretyinfo  = someclass.GetType().GetProperty("Lastname",
            BindingFlags.Instance | BindingFlags.NonPublic);
            var value = propretyinfo!.GetValue(someclass);
            return value!.ToString();
        }

        // Optimized Reflection : a little bit faster
        static string OptimizedReflection()
        {
            var someclass = new PublicClass();
            var value = CachedProprety!.GetValue(someclass);
            return value!.ToString();
        }

        // Using Delegate with Reflection
        private static readonly Func<PublicClass,string> GetPropretyDelegate =
        (Func<PublicClass,string>)Delegate.CreateDelegate(
            typeof(Func<PublicClass,string>),CachedProprety.GetGetMethod(true)!);

        public static string CompileDelegate()
        {
            var someclass = new PublicClass();
            return GetPropretyDelegate(someclass);
        }
}

public class PublicClass
{
    public string name { get ; set ;} = "Kimdur";

    private string Lastname { get; set;} = "Kimdur";
}