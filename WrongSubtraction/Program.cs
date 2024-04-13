using static System.Console;
using static System.Convert;
using static System.Math;


long n; int k;

string str = ReadLine();
var arr = str.Split(" ");
n = ToInt64(arr[0]);
k = ToInt32(arr[1]);

for(int i = 0; i < k; i++)
{
    if(n%10 == 0)
    {
        n /= 10;
    }
    else
    {
        n--;
    }
}

WriteLine(n);