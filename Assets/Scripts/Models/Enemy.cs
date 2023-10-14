using Assets.Scripts.Models;

public class Enemy : Creature
{
    public Enemy(int hp, int damage)
    {
        this.hp = hp;
        this.damage = damage;
    }

    public Enemy()
    {
        hp = 100;
        damage = 10;
    }

    public void GetDamage(int damage)
    {
        HP -= damage;
    }
}
