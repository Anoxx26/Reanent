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
        private TMP_Text text;

        public void ShowHp()
        {
            text.text = creature.HP.ToString();
        }
    }
}
