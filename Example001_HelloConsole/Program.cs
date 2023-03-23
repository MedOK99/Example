// Пробую язык C#endregion

int count = 0;
int distance = 10000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int DogSpeed = 5;
int Friend = 2;

while (distance > 10)
  if (Friend == 1)
    int Time = distance / (FirstFriendSpeed + DogSpeed);
    int Friend = 2;

  else
    int Time = distance / (SecondFriendSpeed + DogSpeed);
    int Friend = 1; 

distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * Time;
count++;
Console.WriteLine("count");


