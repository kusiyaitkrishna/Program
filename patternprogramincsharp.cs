using System;
//ALL CREDIT GOES TOWARDS THE KUSIYAIT KRISHNA WHO HAVE WRITTEN ALL PROGRAM FOR THOSE ONE WHO HAVE INTEREST ON IT

namespace simpleprogram
{
    class Program
    {
       
        static void pattern()
            /*
             1
             12
             123
             1234
             12345
             */
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        static void pattern2()
            /*
            12345
            1234
            123
            12
            1
             */

        {
            for(int i = 5; i >= 1; i--)
            {
                for(int j = 1;j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        static void pattern3()

            /*
                  5
                 45
                345
               2345
              12345 
             */
        {
            for (int i = 1; i <= 5; i++)
            {
                for(int j=1; j <=5; j++)
                {
                    if (j >= 6 - i)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                   
                }
                Console.WriteLine();
            }
        }
        static void pattern4()

            /*
             12345
              2345
               345
                45
                 5
             */
        {
            for(int i = 1;i <= 5; i++)
            {
                for(int j = 1;j <= 5; j++)
                {
                    if ((j >= i) && (j <= 5))
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
               Console.WriteLine();

            }
        }
        static void pattern5()
            /*
             5
            456
           34567
          2345678
         123456789
             */
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j=1;j <= 9; j++)
                {
                    if ((j>=6-i)&&(j<=4+i))
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
        static void pattern6()
            /*
             5
            4 5
           3 4 5 
          2 3 4 5 
         1 2 3 4 5 
            
             */
        {
            for(int i = 1;i<=5; i++)
            {
                int k = 1;
                for (int j = 1; j <= 9; j++)
                   
                {
                    
                    if ((j >= 6 - i)&&(j<=4+i)&&(k==1)){ 
                        Console.Write(j);
                        k = 0;
                    }
                    else
                    {
                        Console.Write(" ");
                        k =1;

                    }
                }
                Console.WriteLine(" ");
            }
        }
        static void pattern7()
            /*
             123456789
             1234 6789
             123   789
             12     89
             1       9
             
             */
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if ((j <= 6 - i)|| (j >= 4 + i))
                    {
                        Console.Write(j);

                    }
                    else
                    {
                        Console.Write(' ');

                    }
                    
                }
                Console.WriteLine(' ');
            }
        }
        static void pattern8()
        /*
               1
              121
             12321
            1234321
         */
        {
            for (int i= 1; i <= 4; i++)

            {
                int k=1;
                for(int j = 1;j <= 7; j++)
                {
                    if ((j>=5-i)&&(j<=3+i))
                    {
                        Console.Write(k);
                        if (j < 4)
                        {
                            k = k + 1;
                        }
                        else
                        {
                            k=k-1;
                        }
                    }
                    else
                    {
                        Console.Write(' ');
                    }

                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
           
            //YOU CAN RUN ABOVE PROGRAM BY CALLING FROM HERE
            pattern();
            pattern2();
            pattern3();
            pattern4();
            pattern5(); 
            pattern6();
            pattern7();
            pattern8();
           

        }

    }

}
