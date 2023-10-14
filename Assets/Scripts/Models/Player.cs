using Assets.Scripts.Models;

public class Player : Creature
{
    public Player(int hp, int damage)
    {
        this.hp = hp;
        this.damage = damage;
    }

    public Player()
    {
        hp = 100;
        damage = 10;
    }

    public void Attack(Enemy enemy)
    {
        enemy.GetDamage(Damage);
    }
}
