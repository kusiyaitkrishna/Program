using System;
namespace converter
{
    class Converter
    {
       

    //Function to calculate of age of user
    static void agecalculator()
        {
            //Initializing variable for date of birth
            int y1, m1, d1;
            //Initializing variable for present date
            int y2, m2, d2;
            //For storing result
            int y3,m3, d3;

            //Taking input of birth date of user
            Console.WriteLine("Enter your birth year:-");
            y1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your birth month:-");
            m1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your birth day:-");
            d1=Convert.ToInt32(Console.ReadLine());
            //Taking input of present date 
            Console.WriteLine("Enter present year");
            y2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter present month:-");
            m2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter present day");
            d2=Convert.ToInt32(Console.ReadLine());
            //Checking condition
            if ((d1 > d2) && (m1 > m2))
            {
                d2 += 30;
                m2 -= 1;
                m2 += 12;
                y2 -= 1;
                //Calculation
                y3 = y2 - y1;
                m3 = m2 - m1;
                d3 = d2 - d1;
                //Displaying result
                Console.WriteLine(y3 + "  Year\t" + m3 + "  Month\t" + d3 + "  Days");
            }
            else if ((d1 > d2) && (m1 < m2))
            {
                d2 += 30;
                m2 -= 1;
                //calculation
                y3 = y2 - y1;
                m3 = m2 - m1;
                d3 = d2 - d1;
                Console.WriteLine(y3 + "  Year\t" + m3 + "  Month\t" + d3 + "  Days");
            }
            else if ((d1 < d2) && (m1 > m2))
            {
                m2 += 12;
                y2 -= 1;
                //calculation
                y3 = y2 - y1;
                m3 = m2 - m1;
                d3 = d2 - d1;
                Console.WriteLine(y3 + "  Year\t" + m3 + "  Month\t" + d3 + "  Days");
            }
            else if ((d1 > d2) && (m1 == m2))
            {
                m2 += 12;
                y2 -= 1;
                d2 += 30;
                m2 -= 1;
                //calculation
                y3 = y2 - y1;
                m3 = m2 - m1;
                d3 = d2 - d1;
                Console.WriteLine(y3 + "  Year\t" + m3 + "  Month\t" + d3 + "  Days");
            }
               else if ((d1 == d2) && (m1 > m2))
            {
                m2 += 12;
                y2 -= 1;
              
                //calculation
                y3 = y2 - y1;
                m3 = m2 - m1;
                d3 = d2 - d1;
                Console.WriteLine(y3 + "  Year\t" + m3 + "  Month\t" + d3 + "  Days");
            }
            else
            {
                //calculation
                y3 = y2 - y1;
                m3 = m2 - m1;
                d3 = d2 - d1;
                Console.WriteLine(y3 + "  Year\t" + m3 + "  Month\t" + d3 + "  Days");
            }



        }

   
    static void Main(string[] args)
    {
            
            agecalculator();
         

    }

    }
}

