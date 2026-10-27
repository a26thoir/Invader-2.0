namespace Invaders_2._0;

public class Scene
{
    // Fields

    private List<Entity> Entities = new();
    
    
    
    // Constructor

    public Scene() { }

    // Methods
    
    // Update

    public void UpdateAll(Scene scene, float deltaTime)
    {
        Console.WriteLine("Todd Howard");
    }
    
    // Render

    public void RenderAll(RenderTarget target)
    {
        Console.WriteLine("It Just Works!");
    }

    public void DestroyInactive(int i)
    {
        Entities.RemoveAt(i);
    }

}