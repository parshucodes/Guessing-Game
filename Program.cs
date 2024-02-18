class Program
{
    static void Main(string[] args)
    {
        int ranq = randno(1, 101);
        int count=1;
        while (true)
        {
            Console.WriteLine("Enter a number between 1 to 100");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input>ranq)
            {
                Console.WriteLine("THe number you Guessed is High, Enter a lower number then, {0}",input);
                count++;
            }
            else if(input<ranq)
            {
                Console.WriteLine("THe number you Guessed is Low, Enter a Higher number then, {0}",input);
                count++;
            }
            else
            {
                Console.WriteLine("You guessed the number right, the number is:{0}",input);
                Console.WriteLine("It took you {0} {1}",count,count==1?"try":"tries");
                break;
            }
        }
    }
    static int randno(int min, int max)
    {
        Random rand = new Random();
        return rand.Next(min,max);
    }
}