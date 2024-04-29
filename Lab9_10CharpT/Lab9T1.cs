namespace Lab9_10CharpT
{
    public class Lab9T1
    {
        public void Run()
        {
            Console.WriteLine("\tTASK 1");
            string prefixExpression = "* 2 + 5 * 3 4"; // префіксний вираз
            Console.WriteLine("Префіксний вираз: " + prefixExpression);
            int result = CalculatePrefixExpression(prefixExpression);
            Console.WriteLine("Результат обчислення префіксного виразу: " + result);
        }

        static int CalculatePrefixExpression(string expression)
        {
            Stack<int> stack = new Stack<int>();
            string[] tokens = expression.Split(' ');

            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                string token = tokens[i];

                if (IsNumeric(token)) // Якщо токен - число, кладемо його в стек
                {
                    stack.Push(int.Parse(token));
                }
                else // Якщо токен - оператор, виконуємо операцію з двох верхніх елементів стеку
                {
                    int operand1 = stack.Pop();
                    int operand2 = stack.Pop();

                    switch (token)
                    {
                        case "+":
                            stack.Push(operand1 + operand2);
                            break;
                        case "-":
                            stack.Push(operand1 - operand2);
                            break;
                        case "*":
                            stack.Push(operand1 * operand2);
                            break;
                        case "/":
                            stack.Push(operand1 / operand2);
                            break;
                        default:
                            throw new ArgumentException("Невідомий оператор: " + token);
                    }
                }
            }

            return stack.Pop();
        }

        public static bool IsNumeric(string token)
        {
            return int.TryParse(token, out _);
        }
    }
}
