double distance0 = 10;
double firstFriendSpeed = 1;
double secondFriendSpeed = 2;
double dogSpeed = 5;
double distance = 10000; 
double time;
int count = 0, friend = 2;  // мы бежим ко второму другу

while (distance > distance0)
{
    if (friend == 2)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    time = distance / (firstFriendSpeed + dogSpeed);
    friend = 2;
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}
Console.WriteLine(count);