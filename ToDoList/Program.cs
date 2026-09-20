List<string> toDoList = new();
bool exit = false;

Console.WriteLine("Hello");

while (!exit)
{
    Console.WriteLine("\nWhat do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    Console.WriteLine();

    string userInput = Console.ReadLine();

    switch (userInput.ToLower())
    {
        case "s":
            ShowList();
            break;

        case "a":
            AddToDO();
            break;

        case "r":
            RemoveTodo();
            break;

        case "e":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Incorrect input");
            break;
    }
}


void ShowList()
{
    if (toDoList.Count <= 0)
    {
        NoToDoMessage();
        return;
    }

    for (int i = 0; i < toDoList.Count; i++)
    {
        Console.WriteLine("All TODOs");
        Console.WriteLine((i + 1) + ". " + toDoList[i]);
    }
}

void AddToDO()
{
    string userInput;
    bool isValid;

    do
    {
        Console.WriteLine("\nEnter the TODO description:");
        userInput = Console.ReadLine();

        if (userInput.Length == 0)
        {
            Console.WriteLine("The description cannot be empty.\nNo TODO is added");
            isValid = false;
        }
        else if (toDoList.Contains(userInput))
        {
            Console.WriteLine("The description must be unique.\nNo TODO is added.");
            isValid = false;
        }
        else
        {
            isValid = true;
        }

    } while (!isValid);

    toDoList.Add(userInput);
    Console.WriteLine("TODO succesfully added: " + userInput);
}

void RemoveTodo()
{
    if (toDoList.Count == 0)
    {
        NoToDoMessage();
        return;
    }

    Console.WriteLine("\nSelect the number of the TODO you want to remmove");
    ShowList();
    bool isNumber = int.TryParse(Console.ReadLine(), out int index);
    index--;

    if (isNumber && index < toDoList.Count && index >= 0)
    {
        Console.WriteLine("Todo removed: " + toDoList[index].ToString());
        toDoList.RemoveAt(index);
    }
    else
    {
        Console.WriteLine("You must enter a number from the list");
    }
}

void NoToDoMessage()
{
    Console.WriteLine("No TODOs have been added yet.");
}