#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a, b, c;
    printf("Type a date in correct form of dd/m/yyyy");
    findWeekDayOfDate(a, b, c);
}

int findWeekDayOfDate(int day, int month, int year)
{
    int y, e, a, r, c, save, cc, yc, mc, result;

    save = year; // Step 1 => Century Part
    y = year / 1000;
    e = (year / 100) % 10;

    if ((10 * y + e) % 4 == 0)
    {
        cc = 6;
    }
    else if ((10 * y + e) % 4 == 1)
    {
        cc = 4;
    }
    else if ((10 * y + e) % 4 == 2)
    {
        cc = 2;
    }
    else if ((10 * y + e) % 4 == 3)
    {
        cc = 0;
    }

    year = save; // Step 2 => Year Part
    r = year % 10;
    year = year / 10;
    a = year % 10;
    yc = ((a * 10 + r) + (a * 10 + r) / 4) % 7;

    if (month == 1)
    { // Step 3 => Month Part
        mc = 0;
    }

    else if (month == 2)
    {
        mc = 3;
    }
    else if (month == 3)
    {
        mc = 3;
    }
    else if (month == 4)
    {
        mc = 6;
    }
    else if (month == 5)
    {
        mc = 1;
    }
    else if (month == 6)
    {
        mc = 4;
    }
    else if (month == 7)
    {
        mc = 6;
    }
    else if (month == 8)
    {
        mc = 2;
    }
    else if (month == 9)
    {
        mc = 5;
    }
    else if (month == 10)
    {
        mc = 0;
    }
    else if (month == 11)
    {
        mc = 3;
    }
    else if (month == 12)
    {
        mc = 5;
    }

    if (year % 4 == 0 && (month == 1 || month == 2))
    {
        mc = mc - 1;
    }
    if ((yc + mc + cc + day) % 7 == 0)
    {
        printf("Sunday");
    }
    else if ((yc + mc + cc + day) % 7 == 1)
    {
        printf("Monday");
    }
    else if ((yc + mc + cc + day) % 7 == 2)
    {
        printf("Tuesday");
    }
    else if ((yc + mc + cc + day) % 7 == 3)
    {
        printf("Wednesday");
    }
    else if ((yc + mc + cc + day) % 7 == 4)
    {
        printf("Thursday");
    }
    else if ((yc + mc + cc + day) % 7 == 5)
    {
        printf("Friday");
    }
    else if ((yc + mc + cc + day) % 7 == 6)
    {
        printf("Saturday");
    }
}