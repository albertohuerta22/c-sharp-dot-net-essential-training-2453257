using OOPAdventure;

Text.LoadLanguage(new English());

Console.WriteLine(Text.Language.ChooseYourName);

//Console.WriteLine("Hello, what is your name?");

var name = Console.ReadLine();

if (name == String.Empty){
    name = Text.Language.DefaultName;
}

var player = new Player(name);

Console.WriteLine(Text.Language.Welcome, player.Name);

var house = new House(player);