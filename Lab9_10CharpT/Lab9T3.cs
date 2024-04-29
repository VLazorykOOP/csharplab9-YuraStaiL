using System.Collections;

namespace Lab9_10CharpT
{
    public class Lab9T3
    {
        public void RunPrefixExpression()
        {
            Console.WriteLine("\tTASK 3.1");

            string prefixExpression = "* 2 + 5 * 3 4"; // Приклад префіксного виразу

            try
            {
                ArrayList stack = new ArrayList();

                string[] tokens = prefixExpression.Split(' ');

                // в зворотньому порядку
                for (int i = tokens.Length - 1; i >= 0; i--)
                {
                    string token = tokens[i];

                    if (Lab9T1.IsNumeric(token))
                    {
                        stack.Add(int.Parse(token));
                    }
                    else
                    {
                        int operand1 = (int)stack[stack.Count - 1];
                        int operand2 = (int)stack[stack.Count - 2];
                        stack.RemoveAt(stack.Count - 1);
                        stack.RemoveAt(stack.Count - 1);

                        switch (token)
                        {
                            case "+":
                                stack.Add(operand1 + operand2);
                                break;
                            case "-":
                                stack.Add(operand1 - operand2);
                                break;
                            case "*":
                                stack.Add(operand1 * operand2);
                                break;
                            case "/":
                                stack.Add(operand1 / operand2);
                                break;
                            default:
                                throw new ArgumentException("Невідомий оператор: " + token);
                        }
                    }
                }

                int result = (int)stack[0];
                Console.WriteLine("Результат обчислення префіксного виразу: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Сталася помилка: " + ex.Message);
            }
        }

        public void RunWordAnalyze()
        {
            Console.WriteLine("\tTASK 3.2");
            string filePath = "input1.txt";

            try
            {
                ArrayList wordsList = new ArrayList();
                ArrayList upperCase = new ArrayList();
                ArrayList lowerCase = new ArrayList();

                // Читаємо вміст текстового файлу та додаємо слова до ArrayList
                string[] words = System.IO.File.ReadAllText(filePath)
                                            .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                wordsList.AddRange(words);

                foreach (string word in wordsList)
                {
                    if (char.IsUpper(word[0]))
                    {
                        upperCase.Add(word);
                    }
                    else if (char.IsLower(word[0]))
                    {
                        lowerCase.Add(word);
                    }
                }

                Console.WriteLine("Слова, що починаються з великої літери:");
                if (upperCase.Count > 0)
                {
                    foreach (string word in upperCase)
                    {
                        Console.WriteLine(word);
                    }
                }

                Console.WriteLine("\nСлова, що починаються з малої літери:");
                if (lowerCase.Count > 0)
                {
                    foreach (string word in lowerCase)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Сталася помилка: " + ex.Message);
            }
        }
    }
}
