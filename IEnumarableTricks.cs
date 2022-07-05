namespace Nick_Chapsas
{
    public class IEnumerableTricks
    {
        /// <summary>
        /// IEnumerable ni countni olishni yangi oson yo'li
        /// </summary>
        public void TryGetNonEnumeratedCount()
        {
            var names = new[] { "Nick", "Mike", "John", "Leyla", "David", "Damian" };
            if (names.TryGetNonEnumeratedCount(out var count))
            {
                Console.WriteLine(count);
            }
        }
    }
}