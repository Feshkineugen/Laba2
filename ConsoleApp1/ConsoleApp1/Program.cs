class Program
{
    public static void Main(string[] args)
    {

        Random rnd = new Random();
        int[] array = new int[1000];
        int a = 10001, b = 10001;
        for (int i = 0; i < array.Length; i++)
        {
            int num = rnd.Next(1, 1000);
            array[i] = num;
            Console.WriteLine(num);
        }
        for (int i = 0; i < 1000; i++)

            for (int j = i + 1; j < 100; j++)

                if (array[i] * array[j] < a * b && array[i] * array[j] % 21 == 0)

                {
                    a = array[i];
                    b = array[j];
                }

        if (a * b % 21 == 0)
        {
            Console.WriteLine("Минимальные числа массива {" + a + ", " + b + "}");
            Console.WriteLine("Минимальное число R кратное 14 = " + a * b + " ");
        }
        else Console.WriteLine(" - 1");

    }
}