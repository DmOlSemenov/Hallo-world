int distanse = 10000;
int a = 3;
int b = 2;
int d = 10;
int count = 0;
while (distanse > 10)
{
    int time = 0;
    if (count % 2 == 0)
    {
        time = distanse / (a + d);
        distanse = (a + b) * time;
    }
    if (count % 2 > 0)
    {
        time = distanse / (b + d);
        distanse = (a + b) * time;
    }
    count++;
}
Console.WriteLine(count);