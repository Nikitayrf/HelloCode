Console.WriteLine("Введите расстояние больше 10 : ");
double distance = Convert.ToDouble(Console.ReadLine());
int count = 0;
int firstFriendsSpeed = 1;
int secondFriendsSpeed = 2;
int dogSpeed = 5;
int friend = 2;

while (distance > 10)
{
    double time = 0;

    if (friend == 1)
    {
        time = distance / (secondFriendsSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (firstFriendsSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendsSpeed + secondFriendsSpeed) * time;
    count++;
    
    Console.WriteLine($"Время: {time}");
    Console.WriteLine($"Расстояние: {distance}");
}
Console.WriteLine($"Собака пробежала: {count}  раз");