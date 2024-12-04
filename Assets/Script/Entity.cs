using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;

namespace TowerDefense
{
    public abstract class Entity : MonoBehaviour
    {
        [field:SerializeField]protected float health {get; set;}
        [field:SerializeField]protected float attackTime {get; set;}
        [field:SerializeField]protected TextMeshPro healthText {get; set;}
        float maxHealth;
        public static event Action<GameObject> entityDied;

        protected virtual void Start(){
            maxHealth = health;
            SetHealthText();
        }

         protected void EntityDied()
        {
            entityDied?.Invoke(this.gameObject);
        }
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
