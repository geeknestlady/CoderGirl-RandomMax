using System;


namespace RandomMax
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Generate a list of 100 random integers between 0 and 1000 and ouput the maximum value.
            int randomInt = 0;
            
            int[] randomNums = new int[100];

            for (int i = 0; i < 100; i++)
            {
                randomInt = new Random().Next(0, 1000);
                //Console.WriteLine(i);
                //Console.WriteLine(randomInt);
                randomNums[i] = randomInt;
                
                
            }
            int maxValue = randomNums[0];
            for (int j = 0; j < randomNums.Length; j++)
                {
                    if (maxValue < randomNums[j])
                    {
                        maxValue = randomNums[j];
                       // Console.WriteLine(j);
                    }
               // Console.WriteLine("MaxValue Not found");

                }




            Console.WriteLine(maxValue);
            Console.ReadLine();
        }
    }
}
