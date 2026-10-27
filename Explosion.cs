namespace Invaders_2._0;

public class Explosion : Entity
{
    
    // Fields

    private float counter = 0;
    
    // Constructor

    public Explosion(Vector2f spawnPosition)
    {
        sprite.Position = spawnPosition;
        collideable = false;
    }
    
    // Methods

    public void CountDown(float deltaTime)
    {
        counter += deltaTime;
        
        switch (counter)
        {
            case < 0.25f :
                // TODO Implement explosion
                break;
            
            case < 0.50f :
                SetInactive();
                break;
        }

    }

    public override void Update(Scene scene, float deltaTime)
    {
        
    }


}