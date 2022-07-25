namespace Nick_Chapsas
{
    public class EnumTricks
    {
        /// <summary>
        /// Enumni ToString metodini Optimizatsiya qilish:
        /// </summary>
        public void Example()
        {
        var simplestring = HumanState.Working.ToString();

        var flags = HumanState.Working.ToString("F");

        var intText = HumanState.Working.ToString("D");

        var Hextext = HumanState.Working.ToString("X");

        System.Console.WriteLine(simplestring);
        System.Console.WriteLine(flags);
        System.Console.WriteLine(intText);
        System.Console.WriteLine(Hextext);
        }
        
        // // To string metodini optimizatsiya qilish uchun yangi metod switch case:

        static string FastMethod(HumanState state)
        {
            switch(state)
            {
                case HumanState.Idle:
                    return nameof(HumanState.Idle);
                case HumanState.HaveFun:
                    return nameof(HumanState.HaveFun);
                case HumanState.Dead:
                    return nameof(HumanState.Dead);
                case HumanState.Sleeping:
                    return nameof(HumanState.Sleeping);
                case HumanState.Working:
                    return nameof(HumanState.Working);
                default :
                        throw new ArgumentOutOfRangeException(nameof(state),state,null);
            }
        }
    }
}
public enum HumanState
{
    Idle,
    Working,
    Sleeping,
    HaveFun,
    Dead
}