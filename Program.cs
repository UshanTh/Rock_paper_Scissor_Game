//get user input and assign to player1 variable
Console.Write("Player 1 (Select only \"Rock\",\"Paper\" & \"Scissors\"): ");
string? player1 = Console.ReadLine();

//array initialization
string[] items = ["Rock","Paper", "Scissors"];

//Create an instance of Random
Random random = new Random();

//Generate a random index within the bounds of the array
int randomItemIndex = random.Next(0, items.Length);
string randomItem = items[randomItemIndex];

//check user entered item contains an array
if (items.Contains(player1, StringComparer.OrdinalIgnoreCase))
{
    // Normalize input to match array case
    player1 = items.First(item => item.Equals(player1, StringComparison.OrdinalIgnoreCase));
    
    //Print the element at the random index
    Console.WriteLine("Player 2 :" + randomItem);

    // Determine the result                                                       
    string result;
    if (player1 == "Rock" && randomItem == "Scissors" || 
        player1 == "Paper" && randomItem == "Rock" || 
        player1 == "Scissors" && randomItem == "Paper")
    {
        result = $"Player 1 Win..! Player 2 Choose {randomItem}";
    }
    else if (player1 == randomItem)
    {
        result = $"Game Draw..! Player 2 Choose {randomItem}";
    }
    else
    {
        result = $"Player 2 wins..!Try Again.. Player 2 Choose {randomItem}";
    }
    
    //print the result
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Wrong input.. Try again");
}



