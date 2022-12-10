const number = parseInt(prompt("Bir sayi giriniz: "));

oddishOrEvenish(number);

function oddishOrEvenish(number) 
{
    var sum=0;
    while(parseInt(number / 10) != 0)
    {
        sum+=number % 10;
        number = parseInt(number / 10);
        
    }

    if(sum%2==1)
    {
        console.log("Even");
    }
    else
    {
        console.log("Odd");
    }

    
}