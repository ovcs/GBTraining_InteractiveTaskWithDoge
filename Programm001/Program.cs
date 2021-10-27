Console.WriteLine("3");
System.Threading.Thread.Sleep(1000);
Console.WriteLine("2");
System.Threading.Thread.Sleep(1000);
Console.WriteLine("1");
System.Threading.Thread.Sleep(1000);
Console.WriteLine("Старт");
Console.WriteLine(" ");

double distance0 = 10;
double firstFriendSpeed = 1;
double secondFriendSpeed = 2;
double dogSpeed = 5;
double distance = 10000;
double time;
int count = 0, friend = 2;  // мы бежим ко второму другу

while (distance > distance0)
{
    System.Threading.Thread.Sleep(500);
    if (friend == 2)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    else
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    Console.Write($"Собачка пробежала {count + 1} раз  |  ");
    Console.WriteLine($"Расстояние: {distance}");
    count++;
}