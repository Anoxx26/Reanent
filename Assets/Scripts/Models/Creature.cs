using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class Creature
    {
        [SerializeField]
        protected int hp;

        [SerializeField]
        protected int damage;

        public int HP { get { return hp; } set { hp = value; } }

        public int Damage { get { return damage; } set { damage = value; } }
    }
}