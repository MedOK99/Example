// Пробую язык C#
// Задача с двумя друзьями и собакой

int count = 0;
int distance = 10000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int DogSpeed = 5;
int Friend = 2;
int Time = 0;

while (distance > 10)
{
  if (Friend == 1)
  {
    Time = distance / (FirstFriendSpeed + DogSpeed);
    Friend = 2;
  }
  
  else
  {
    Time = distance / (SecondFriendSpeed + DogSpeed);
    Friend = 1; 
  }
}
distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * Time;
count++;

Console.WriteLine("count");


