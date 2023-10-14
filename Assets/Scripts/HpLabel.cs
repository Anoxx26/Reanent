using Assets.Scripts.Models;
using TMPro;
using UnityEngine;

namespace Assets.Scripts
{
    public class HpLabel : MonoBehaviour
    {
        [SerializeField]
        private Creature creature;

        [SerializeField]
        private TextMeshPro text;

        public void ShowHp()
        {
            text.text = creature.HP.ToString();
        }
    }
}
