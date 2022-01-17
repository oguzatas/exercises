#include <stdio.h>

int main() 
{
    int n,temp,sum=0,r;
    printf("Number input:");
    scanf("%%d",n);
    temp=n;
    while(n>0)  //reverse number algorythm

    {
        r=n%10; // getting the last digit of number,r
        sum=(sum*10)+r; //adding the number r, also multiplicating with 10 to increase digit number
        n=n/10; // substracting the last digit (r) from our first number (n) and it becomes new (n)
    }

    if(temp==sum) 
    {
        printf("the number is palindrome");
    }
    else {
        printf("the number is not palindrome");
    }

    return 0;
}