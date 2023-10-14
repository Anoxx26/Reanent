using Assets.Scripts.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
