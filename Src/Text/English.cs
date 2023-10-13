using OOPAdventure;

public class English : Language
{
    public English()
    {
        ChooseYourName = "Hello, What is your name?";
        DefaultName = "No Name";
        Welcome = "Welcome {0}!";
        DefaultRoomName = "Room {0} ({1}, {2})";
        DefaultRoomDescription = "You are in the room with doors to the {0}.";
        ActionError = "You can't do that.";
    }
}