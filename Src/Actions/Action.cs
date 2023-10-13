namespace OOPAdventure;

public abstract class Action
{
    public virtual string Name => "";

    public virtual void Execute(string[] arg)
    {
        throw new Exception("Nothing to Execute");
    }

}