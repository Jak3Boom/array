namespace exercise
{
    class arrays
    {
        static void Main(string[] args)
        {
            int[] myArray1 = new int[5];
            int[] myArray2 = new int[5];
            int[] myArray3 = new int[5];

            //
            // Инициализация массива 1
            //

            for (int i = 0; i < myArray1.Length; i++)
            {
                Console.WriteLine($"Введите значение {i}-го элемента массива myArray1");
                myArray1[i] = int.Parse(Console.ReadLine());
            }
            string str = string.Join(", ", myArray1);

            //
            // Инициализация массива 2
            //

            Console.WriteLine("\n--------------------------------------------\n");

            for (int i = 0; i < myArray2.Length; i++)
            {
                Console.WriteLine($"Введите значение {i}-го элемента массива myArray2");
                myArray2[i] = int.Parse(Console.ReadLine());
            }
            string strarray = string.Join(", ", myArray2);

            //
            // Инициализация массива 3
            //

            Console.WriteLine("\n--------------------------------------------\n");

            for (int i = 0; i < myArray3.Length; i++)
            {
                Console.WriteLine($"Введите значение {i}-го элемента массива myArray3");
                myArray3[i] = int.Parse(Console.ReadLine());
            }
            string arraystr = string.Join(", ", myArray3);

            // Вывод массивов

            Console.WriteLine("\n--------------------------------------------\n");

            Console.WriteLine("Вывод массивов:");

            Console.WriteLine($"Массив myArray1: [{str}];\tСумма его элементов равна {myArray1.Sum()}");
            Console.WriteLine($"Массив myArray2: [{strarray}];\tСумма его элементов равна {myArray2.Sum()}");
            Console.WriteLine($"Массив myArray3: [{arraystr}];\tСумма его элементов равна {myArray3.Sum()}");

            Console.WriteLine("\n--------------------------------------------\n");

            if (myArray1.Sum() > myArray2.Sum() && myArray1.Sum() > myArray3.Sum())
            {
                Console.WriteLine("Наибольшая сумма элементов в массиве myArray1");
            }
            if (myArray2.Sum() > myArray1.Sum() && myArray2.Sum() > myArray3.Sum())
            {
                Console.WriteLine("Наибольшая сумма элементов в массиве myArray2");
            }
            if (myArray3.Sum() > myArray1.Sum() && myArray3.Sum() > myArray2.Sum())
            {
                Console.WriteLine("Наибольшая сумма элементов в массиве myArray3");
            }
        }
    }
}