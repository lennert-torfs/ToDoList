Console.WriteLine("Hello");

List <string> toDoList = new();
bool exit = false;

while(!exit)
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
            exit = true;
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
    }
    else
    {
        for (int i = 0; i < toDoList.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + toDoList[i]);
        }
    }
}

void AddToDO()
{
    Console.WriteLine("\nEnter the TODO description:");
    string userInput = Console.ReadLine();
    if (userInput.Length > 0)
    {
        if (!toDoList.Contains(userInput))
        {
            toDoList.Add(userInput);
            Console.WriteLine("TODO succesfully added: " + userInput);
        }
        else
        {
            Console.WriteLine("The description must be unique.\nNo TODO is added.");
            AddToDO();
        }

    }
    else
    {
        Console.WriteLine("The description cannot be empty.\nNo TODO is added");
        AddToDO();
    }
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

    try
    {
        int index = Convert.ToInt16(Console.ReadLine()) - 1;
        Console.WriteLine("Todo removed: " + toDoList[index].ToString());
        toDoList.RemoveAt(index);

    }
    catch
    {
        Console.WriteLine("You must enter a number");
        
    }
}

void NoToDoMessage()
{
    Console.WriteLine("No TODOs have been added yet.");
}