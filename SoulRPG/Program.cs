using WandererOfSouls;

public class Program
{
    private static void Main(string[] args)
    {
        MenuActionService actionsService = new MenuActionService();
        string choice;
        Console.WriteLine("Welcome to Wanderer of souls");
        while (true)
        {
            Console.WriteLine("Select below what you wanna do.");
            actionsService.choices("New Game", "Leave", null, null);
            choice = Console.ReadLine();
            if(choice == "1" || choice == "2")
            {
                break;
            }
        }
            switch(choice)
            {
                case "1":
                    actionsService.StartGameView();
                    break;
                case "2":

                    break;
            }
        
    }
}

