namespace Invaders_2._0;

public abstract class Ship : Entity
{
    // Fields

    private Factions faction; // Proper naming convention for private variables is to put an underscore before, i.g _factions
    protected int health;
    protected int damage;
    protected float shotCoolDown;
    protected float timeSinceShot;
    
    // Constructor

    public Ship(Factions setFaction, int setHealth, int setDamage, int setSpeed, float setShotCoolDown) // Look up "this"
    {
        this.faction = setFaction;
        health = setHealth;
        damage = setDamage;
        speed = setSpeed;
        shotCoolDown = setShotCoolDown;
        timeSinceShot = shotCoolDown;

    }
    
    // Methods

    public override void Update(Scene scene, float deltaTime)
    {
        timeSinceShot += deltaTime;
        sprite.Position += direction * speed * deltaTime;
    }

    public abstract void Shoot();

    public virtual void TakeDamage(int amount) // Health behöver inte skrivas in då alla skepp redan har koll på sin egen health
    {
        health -= amount;
    }

    public int Health // A Read Only of the private field 'health' that can be accessed outside the class
    {
        get => health;
    }

    public int Damage // Read Only, om ett värde tillhör en klass är det oftast bäst att värdet bara kan ändras i klassen själv, även om interaktion med andra klasser orsakar förändringen
    {
        get => damage;
        
    }

}