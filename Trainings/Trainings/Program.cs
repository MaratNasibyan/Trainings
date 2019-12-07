using System;

namespace Trainings
{
    class Program
    {
        #region Exception

        public static void Exception1()
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"result: {y}");                   
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"it is exception {ex.Message}");
            }            
        }

        public static void Exception2()
        {
            int x = 1;
            int y = 0;

            try
            {
                int result = x / y;
            }
            catch (DivideByZeroException) when (y == 0 && x == 0)
            {
                Console.WriteLine("y не должен быть равен 0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Exception3()
        {
            // in this case when there is first excepton 2nd exception doesn't call
            try
            {
                int[] numbers = new int[4];
                numbers[7] = 9;     // IndexOutOfRangeException

                int x = 5;
                int y = x / 0;  // DivideByZeroException
                Console.WriteLine($"result: {y}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("it is exception DivideByZeroException");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }

        public static void Exception4()
        {
            // in this case when there is many exception
            // exception class catchs all exception except DivideByZeroException and IndexOutOfRangeException
            try
            {
                object obj = "you";
                int num = (int)obj;     // InvalidCastException
                Console.WriteLine($"Результат: {num}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Возникло исключение IndexOutOfRangeException");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
            Console.Read();
        }

        public static void Exception5()
        {
            // when in catch block there is throw , that means the exception pass to next step 
            try
            {
                try
                {
                    Console.Write("Введите строку: ");
                    string message = Console.ReadLine();
                    if (message.Length > 6)
                    {
                        throw new Exception("Длина строки больше 6 символов");
                    }
                }
                catch
                {
                    Console.WriteLine("Возникло исключение");
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        static void Main(string[] args)
        {            
            //Exception1();
            Exception2();
            Console.WriteLine("Hello World!");
        }
    }
}
