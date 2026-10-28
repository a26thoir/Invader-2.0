namespace Invaders_2._0;

public abstract class Entity
{
    // Fields

    protected Sprite sprite;
    protected bool inactive;
    protected int speed;
    protected Vector2f direction;
    
    // Constructor

    public Entity() {}

    // Methods

    public virtual void Update(Scene scene, float deltaTime)
    {
    }

    public virtual void Render(RenderTarget target)
    {
    }
    

    public FloatRect Bounds
    {
        get => sprite.GetGlobalBounds();
    }


    public virtual void Create()
    {
    }
    

    public void SetInactive() // Maybe, make it virtual later
    {
        inactive = true;
    }
    
    /*public Vector2f Position // Might not need this here
{
    get;
    set;
}*/

}