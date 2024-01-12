using gym_project;

while (true)
{
    try
    {
        Console.WriteLine("choose an option:\n1.add member \n2.add trainer " +
            "\n3.show user with details\n4.reamove member \n5.reamove trainer");

        var option = int.Parse(Console.ReadLine()!);
        switch (option)
        {
            case 1:
                {
                    Console.WriteLine("enter name");
                    var name = Console.ReadLine()!;
                    Console.WriteLine("enter phone numbeer");
                    var phoneNumber = Console.ReadLine()!;
                    Console.WriteLine("how many days?");
                    var days = int.Parse(Console.ReadLine()!);
                    Gymmanagment.AddMember(name, phoneNumber, days);
                    break;
                }
            case 2:
                {
                    Console.WriteLine("enter name");
                    var name = Console.ReadLine()!;
                    Console.WriteLine("enter phone numbeer");
                    var phoneNumber = Console.ReadLine()!;
                    Console.WriteLine("how many days?");
                    var days = int.Parse(Console.ReadLine()!);
                    Gymmanagment.AddTrainer(name, phoneNumber, days);
                    break;
                }
            case 3:
                {
                    foreach (var person in Gymmanagment.GetPeople())
                    {
                        if (person is Member)
                        {
                            person.UserDetails(person);
                        }
                        if (person is Trainer)
                        {
                            person.UserDetails(person);
                        }
                    }
                    break;
                }
            case 4:
                {
                    Console.WriteLine("enter member name");
                    var name = Console.ReadLine()!;
                    Gymmanagment.ReamoveMember(name);
                    break;
                }
            case 5:
                {
                    Console.WriteLine("enter trainer name");
                    var name = Console.ReadLine()!;
                    Gymmanagment.ReamoveTrainer(name);
                    break;
                }
        }
    }
    catch(Exception exception)
    {
        Console.WriteLine(exception.Message);
    }
}