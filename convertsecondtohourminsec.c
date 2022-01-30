#include <conio.h>
#include <stdio.h>

//Function to convert second into hour month and second
int sectohrminsec(int second)
{
    /*
    This function is used to convert second into hour  minute and second as according to user inputed second
    . This function takes input in integer format 
    */
    int hour, minute, r_second;
    //checking condition
    if (second >= 0)
    {
        //Logic or calculation
        //store hour
        hour = (second / 3600);
        second = second % 3600; //Here it extract remaining second after calculating hour
        minute = (second / 60); //Store minute
        second = second % 60;   //Again it extract remaining second after calculationg minute
        r_second = second;      //Remaining second after calculation hour and minute
        //Displaying second
        printf("Time in hour  is %d \t in minute %d \t in second %d", hour, minute, r_second);
    }
    else
    {
        printf("Pass valid value for this operation");
    }
}
int main()
{

    //daytoyrmnday(365);
    //sectohrminsec(358);
    //calculateage();
    return 0;
}
