using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense.TOWER
{
    public class BaseTower : Tower
    {
        public event Action gameOverEvent;
        void OnCollisionEnter2D(Collision2D collision){
            ReduceHealth(10);
            Destroy(collision.gameObject);
            if(health == 0){
                gameOverEvent?.Invoke();
            }
        }
    }

}
