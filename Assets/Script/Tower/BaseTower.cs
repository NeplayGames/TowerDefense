using System;
using System.Collections;
using System.Collections.Generic;
using TowerDefense.NPC;
using UnityEngine;

namespace TowerDefense.TOWER
{
    public class BaseTower : Tower
    {
        public event Action gameOverEvent;
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.transform.TryGetComponent<Npc>(out Npc npc))
            {
                ReduceHealth(10);
                npc.ReduceHealth(Mathf.Infinity);
                if (health == 0)
                {
                    gameOverEvent?.Invoke();
                }
            }

        }
    }

}
