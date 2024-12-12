namespace Cstart.Dogma;
using WorldComponents = Dictionary<string, Dictionary<string, DogmaComponent>>;
using ComponentList = Dictionary<string, DogmaComponent>;
using SystemList = Dictionary<string, DogmaSystem>;
public class World(string worldName)
{
    public string WorldName = worldName;
    public static HashSet<string> avalibleSystems = new(); 
    public HashSet<DogmaComponent> componentsToDispatch = new();
    public HashSet<DogmaComponent> componentsToRemove = new();
    public HashSet<DogmaSystem> systemsToDispatch = new();
    public HashSet<DogmaSystem> systemsToRemove = new();
    public HashSet<string> entitiesInWorld = new();
    private WorldComponents Components = new();
    private SystemList Systems = new();
    public ComponentList getComponentsFrom(string name)
    {
        if(!avalibleSystems.Contains(name)) Console.Error.WriteLine($"component ${name} is not proper component.");
        Components.TryGetValue(name,out var componentList );
        return componentList;
    }
}
