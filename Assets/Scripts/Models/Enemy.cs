using Assets.Scripts.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
