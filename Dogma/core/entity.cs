using System.ComponentModel;

namespace Cstart.Dogma;

public abstract class DogmaEntity
{
    private Guid EntityId  = Guid.NewGuid();
    private string[] EntityMarker = new [] {" "};
    private HashSet<string> EntityTags = new ();
    public HashSet<DogmaComponent> Components = new ();

    public void AddComponent<T>(T component) where T : DogmaComponent
    { 
        component.EntityTags = EntityTags;
        component.EntityID = EntityId;
        component.EntityMarker = EntityMarker;
        Components.Add(component);
    }
    public void SetMarker(string marker)
    {
        this.EntityMarker[0] = marker;
    }
    
}