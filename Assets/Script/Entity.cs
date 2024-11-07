using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace TowerDefense
{
    public abstract class Entity : MonoBehaviour
    {
        [field:SerializeField]protected float health {get; set;}
        [field:SerializeField]protected int attackRate {get; set;}
        [field:SerializeField]protected TextMeshPro healthText {get; set;}

        float maxHealth;

        protected virtual void Start(){
            maxHealth = health;
            SetHealthText();
        }

        protected abstract void EntityDied();
        public void ReduceHealth(float damage){
            this.health -= damage;
            if(health <= 0){
                health = 0;
                EntityDied();
            }
            SetHealthText();
        }

        private void SetHealthText(){
            if(healthText != null)
                healthText.text = $"{health} / {maxHealth}";
        }
    }

}
