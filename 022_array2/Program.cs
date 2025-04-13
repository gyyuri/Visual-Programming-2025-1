namespace _022_array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] lst = new int[20];

            for (int i = 0; i < lst.Length; i++)
            {
                lst[i] = r.Next(101);
            }
            
            foreach(var i in lst)
                Console.Write(i+" ");
            Console.WriteLine();

            //최소, 최대, 평균(합)
            int min = lst[0];
            int max = lst[0];
            int sum = lst[0];

            foreach(var i in lst)
            {
                if (i < min) min = i;
                if (i > max) max = i;
                sum += i;
            }

            Console.WriteLine("min = {0}, max = {1}, avg ={2}", min, max, sum / 20);


        }
    }
}

