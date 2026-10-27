namespace Invaders_2._0;

public class Enemy : Ship
{
    // Fields
    
    // Constructor

    public Enemy(int setHealth) : base(Factions.Enemy, setHealth) // subclass + base constructors interact
    {
    }

    // Methods

    public override void Update(Scene scene ,float deltaTime)
    {

        CheckScreenBounds();
        base.Update(scene, deltaTime);

    }

    public override void TakeDamage(int doesThisWork)
    {
        base.TakeDamage(doesThisWork);

        if (health <= 0)
        {
            // TODO implement explosion
            SetInactive();
        }

    }

    public override void Shoot()
    {
        // TODO Bullets 
    }

    public void CheckScreenBounds()
    {
        // south

        if (sprite.Position.Y >= Program.screenH)
        {
            sprite.Position = new Vector2f(sprite.Position.X, -200);
        }

        // left right

        if (sprite.Position.X <= 0 || sprite.Position.Y >= Program.screenW) direction.X *= -1f;
        

    }

}