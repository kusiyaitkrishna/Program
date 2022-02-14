==============THIS PROGRAM IS USED TO CALCULATE AGE BASED ON USER DATE OF BIRTH AND PRESENT DAY WITH THE HELP OF FUNCTION=============
======ALL CREDIT GOES TOWARDS Kusiyait Krishna WHO HAS WRITTEN THIS PROGRAM==============

#include<conio.h>
#include<stdio.h>


int calculateage()
{
    int y1, m1, d1; //Initializing variable for taking initial age input
    int y2, m2, d2; //Initializing variable for taking final age input
    int y3, m3, d3; //Initializing variable for storing result
    //Taking initial age input from user
    printf("Enter initial age in year:-\n");
    scanf("%d", &y1);
    printf("Enter initial age in month:-\n");
    scanf("%d", &m1);
    printf("Enter initial age in days:-\n");
    scanf("%d", &d1);
    //Taking final age input from user
    printf("Enter final age in year:-\n");
    scanf("%d", &y2);
    printf("Enter final age in month:-\n");
    scanf("%d", &m2);
    printf("Enter final age in days:-\n");
    scanf("%d", &d2);
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
        printf("your age %d year \t %d month \t %d day", y3, m3, d3);
    }
    else if ((d1 > d2) && (m1 < m2))
    {
        d2 += 30;
        m2 -= 1;
        //calculation
        y3 = y2 - y1;
        m3 = m2 - m1;
        d3 = d2 - d1;
        printf("your age %d year \t %d month \t %d day", y3, m3, d3);
    }
    else if ((d1 < d2) && (m1 > m2))
    {
        m2 += 12;
        y2 -= 1;
        //calculation
        y3 = y2 - y1;
        m3 = m2 - m1;
        d3 = d2 - d1;
        printf("your age %d year \t %d month \t %d day", y3, m3, d3);
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
                printf("your age %d year \t %d month \t %d day", y3, m3, d3);
                
            }
        else if ((d1 == d2) && (m1 > m2))
            {
                m2 += 12;
                y2 -= 1;
                
                //calculation
                y3 = y2 - y1;
                m3 = m2 - m1;
                d3 = d2 - d1;
                printf("your age %d year \t %d month \t %d day", y3, m3, d3);
                
            }
    else
    {
        //calculation
        y3 = y2 - y1;
        m3 = m2 - m1;
        d3 = d2 - d1;
        printf("your age %d year \t %d month \t %d day", y3, m3, d3);
    }
}
int main()
{

    //daytoyrmnday(365);
    //sectohrminsec(358);
    //calculateage();
    return 0;
}
//====================================BEST OF LUCK ====================
//===========ENJOY YOUR DAY===============
