namespace Invaders_2._0;

public class Player : Ship, ICollideable
{
    // Fields
    
    private float invincibleTimer;
    
    // Constructor

    public Player(int setHealth, int setDamage, int setSpeed, float setCoolDown) : base(Factions.Player, setHealth, setDamage, setSpeed, setCoolDown)
    {
        
    }
    
    // Methods

    public override void Create()
    {
        base.Create();
    }

    public override void Update(Scene scene, float deltaTime)
    {
        PlayerMove();
        base.Update(scene, deltaTime);
    }

    public override void Shoot()
    { 
        if (Keyboard.IsKeyPressed(Keyboard.Key.Space)) // When using SFML and using Keyboard related events, put additional features within the function, instead of encasing the keyboard event in the additional feature
        {
            if (timeSinceShot > shotCoolDown)
            {
                // TODO Bullet creation
                // TODO And friend

                timeSinceShot = 0;
            }
        }
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
            SetInactive();
        }
    }

    public void PlayerMove()
    {
        
        direction = new (0,0);
        
        if (Keyboard.IsKeyPressed(Keyboard.Key.W)) direction.Y -- ; // Up
        
        if (Keyboard.IsKeyPressed(Keyboard.Key.D)) direction.X ++ ; // Right
        
        if (Keyboard.IsKeyPressed(Keyboard.Key.S)) direction.Y ++ ; // Down
        
        if (Keyboard.IsKeyPressed(Keyboard.Key.A)) direction.X -- ; // Left

        direction = direction / MathF.Sqrt(direction.X * direction.X + direction.Y * direction.Y); // Normalisation

    }



}