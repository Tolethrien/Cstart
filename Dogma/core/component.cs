namespace Cstart.Dogma;

public abstract class DogmaComponent {
    public Guid EntityID = new Guid();
    public string[] EntityMarker = [""];
public HashSet<string> EntityTags = new ();

public void SetMarker(string marker)
{
    this.EntityMarker[0] = marker;
}

public string GetMarker()
{
    return this.EntityMarker[0];
}
}