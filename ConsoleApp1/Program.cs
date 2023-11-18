class zad
{
    static void Main(string[] args)
    {
        double[,] tab1 = new double[,] { { 4.1, 5.0, 6.4, -2.0, -1.0 }, { 2.0, 0.4, -1.5, 1.2, 3.0 }, { 0.2, 4.0, 3.4, 2.0, -5.0 }, { 0.6, 9.1, 4.0, -2.2, -1.2 }, { 5.0, -9.4, -3.5, 2.0, 1.3 } };
        double suma = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i==j)
                {
                    suma = suma + tab1[i, j];
                }
            }
        }
        for (int i=0;i<5;i++)
        {
            for (int j=0;j<5;j++)
            {
                Console.Write(tab1[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Suma liczb po przekątnej wynosi: " + suma);
        Console.ReadKey();
    }
}