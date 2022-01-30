#include <conio.h>
#include <stdio.h>

int daytoyrmnday(int days)
{
    /*
    This function takes input from user in day format and convert it into year month and day as according to user
    inputed day
    */
    //Initializing variable for progran
    int year, month;
    int r_day; //Remaining days after calculating year ,  month

    // we use logic for only positive value as we know days must be positive
    if (days >= 0)
    {
        //logic or calculation
        year = (days / 365);
        days = days % 365;
        month = (days / 30);
        days = days % 30;
        r_day = days;

        //Displaying result
        printf("Date in year%d\t in month%d\t in days%d", year, month, r_day);
    }
    else
    {
        printf("Pass only valid value for this");
    }
}
int main()
{

    //daytoyrmnday(365);
    //sectohrminsec(358);
    //calculateage();
    return 0;
}
