int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


int a1 = 1;
int b1 = 2;
int c1 = 6563;
int a2 = 1;
int b2 = 287;
int c2 = 6;
int a3 = 1;
int b3 = 8162;
int c3 = 6;

int max = Max(Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3));


Console.Write("max = ");
Console.WriteLine(max);
