namespace OmoiotitaStringsChasapis;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Πληκτρολογηστε το πρωτο String για συγκριση : ");
            string s1 = Console.ReadLine().ToLower();
            if (string.IsNullOrEmpty(s1))
            {
                Console.WriteLine("Παρακαλω οχι αδειο string");
                continue;
            }

            Console.WriteLine("Πληκτρολογηστε το δευτερο String για συγκριση : ");
            string s2 = Console.ReadLine().ToLower();
            if (string.IsNullOrEmpty(s2))
            {
                Console.WriteLine("Παρακαλω οχι αδειο string");
                continue;
            }

            if (s1.Length != s2.Length)
            {
                Console.WriteLine("Αλφαριθμητικες ακολουθιες δεν εχουν το ιδιο μηκος οποτε δεν μπορουν να συγκριθουν.");
               Environment.Exit(0);
            }
            
            int similarity = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[i])
                {
                    ++similarity;
                }
            }
            Console.WriteLine("Οι αλφαριθμητικες ακολουθιες ειναι ομοιες κατα ποσοστο : " +
                              (double) similarity / s1.Length * 100 + "%");
            Environment.Exit(0);
        } while (true);
    }
}