namespace _022_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] lst = new int[20];

            Console.Write("배열: ");
            for(int i=0; i<lst.Length; i++)
            {
                lst[i] = r.Next(101);
                Console.Write(" " + lst[i]);
            }Console.WriteLine();


            int min = lst[0];
            int max = lst[0];
            int sum = lst[0];

            for(int i=1; i<lst.Length; i++)
            {
                if(max < lst[i]) max = lst[i];
                if(min>lst[i]) min = lst[i];
                sum += lst[i];
            }

            Console.WriteLine("최대값: " + max);
            Console.WriteLine("최소값: " + min);
            Console.WriteLine("평균값: " + sum / 20);


        }
    }
}
