namespace Invaders_2._0;

public class Enemy : Ship, ICollideable
{
    // Fields
    
    Random random = new();
    
    // Constructor

    public Enemy(int setHealth, int setDamage, int setSpeed, float setCoolDown) : base(Factions.Enemy, setHealth, setDamage, setSpeed, setCoolDown) // subclass + base constructors interact
    {
    }

    // Methods

    public override void Create()
    {
        base.Create();
        SpawnPosition();
        SpawnDirection();
    }
    
    public override void Update(Scene scene ,float deltaTime)
    {

        CheckScreenBounds();
        base.Update(scene, deltaTime);

    }

    public override void Shoot()
    {
        // TODO Bullets 
    }
    
    
    public void WhenCollided(int amount)
    {
        TakeDamage(amount);
    }

    
    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
        if (health <= 0)
        {
            // TODO implement explosion
            SetInactive();
        }

    }

    public void SpawnPosition()
    {
        sprite.Position = new Vector2f(random.Next(0, (int)Program.screenW), random.Next(-200, -50)); // Spawns randomly within screen width, as well as above screen within a certain length

    }

    public void SpawnDirection()
    {

        if (random.Next(0, 2) > 0)
        {
            direction = new Vector2f(-1, 1);
        }
        else
        {
            direction = new Vector2f(1, 1);
        }




    }
    
    public void CheckScreenBounds()
    {
        // south

        if (sprite.Position.Y >= Program.screenH)
        {
            SpawnPosition();
        }

        // left right

        if (sprite.Position.X <= 0 || sprite.Position.Y >= Program.screenW) direction.X *= -1f;
        

    }

}