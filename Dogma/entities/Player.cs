using Cstart.Dogma.components;

namespace Cstart.Dogma.entities;

public class Player : DogmaEntity
{
    public Player()
    {
        this.AddComponent(new Renderer (x:1, y:2));
this.SetMarker("Player");
    }
}