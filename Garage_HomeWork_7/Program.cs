
using Garage_HomeWork_7;

//1

bool İsArrayContains(int[] arr1,int[] arr2)
{
    if(arr2.Length<=1 || arr1.Length<=1)return false;
    int count = 0;
    for (int i = 0; i < arr1.Length-1; i++)
    {
        for (int j = 0; j < arr2.Length-1; j++)
        {
            if (arr1[i] == arr2[j])
            {
                int arr1Next = arr1[i+1];
                int arr2Next = arr2[j+1];
                if (arr1Next == arr2Next)
                {
                    count++;
                }
            }
        }
    }
    return count == arr2.Length - 1;
}

Console.WriteLine(İsArrayContains(new int[] { 1, 2, 3, 4, 7, 9, 12 }, new int[] {4,7,9 }));




//2

User[] users = new User[] {

    new User
    {
        Name="User1",
        Surname="Surname1",
        Username="Username1",
        Passowrd="Password1"
    },
    new Student
    {
        Name="User2",
        Surname="Surname2",
        Username="Username2",
        Passowrd="Password2",
        Grade=7
    },
    new User
    {
        Name="User3",
        Surname="Surname3",
        Username="Username3",
        Passowrd="Password3"
    },
    new Student
    {
        Name="User4",
        Surname="Surname4",
        Username="Username4",
        Passowrd="Password4",
        Grade=12
    },

};

Console.Write("Username:");
var Username=Console.ReadLine();
Console.Write("Password:");
var Password=Console.ReadLine();

User? foundUser= null;

foreach (var user in users)
{
    if(Username==user.Username && Password == user.Passowrd)
    {
        foundUser = user; 
        break;
    }
}

if(foundUser is not null)
{
    var st=foundUser as Student;
    if (st != null) Console.WriteLine($"Student Grade:{st.Grade}");
    else Console.WriteLine("User is not Student");
}
else Console.WriteLine("User not Found");