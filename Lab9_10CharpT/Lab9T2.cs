namespace Lab9_10CharpT
{
    public class Lab9T2
    {
        public void Run()
        {
            Console.WriteLine("\tTASK 2");
            string filePath = "input1.txt";

            try
            {
                Queue<string> capitalWords      = new Queue<string>();
                Queue<string> lowercaseWords    = new Queue<string>();

                string[] words = File.ReadAllText(filePath)
                                     .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (char.IsUpper(word[0]))
                    {
                        capitalWords.Enqueue(word);
                    }
                    else if (char.IsLower(word[0]))
                    {
                        lowercaseWords.Enqueue(word);
                    }
                }

                Console.WriteLine("Слова, що починаються з великої літери:");
                while (capitalWords.Count > 0)
                {
                    Console.WriteLine(capitalWords.Dequeue());
                }

                Console.WriteLine("\nСлова, що починаються з малої літери:");
                while (lowercaseWords.Count > 0)
                {
                    Console.WriteLine(lowercaseWords.Dequeue());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка: {ex.Message}");
            }
        }
    }
}
