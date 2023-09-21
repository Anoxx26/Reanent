using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    [SerializeField]
    private int hp;
    
    [SerializeField]
    private int damage;

    public int HP { get { return hp; } set { hp = value; } }

    public int Damage { get { return damage; } set { damage = value; } }

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
}
