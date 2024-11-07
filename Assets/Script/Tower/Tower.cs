using System.Collections;
using System.Collections.Generic;
using TowerDefense.NPC;
using UnityEngine;

namespace TowerDefense.TOWER
{
    public class Tower : Entity
    {
     // [SerializeField] private GameObject bulletGO;

      public NPCManager nPCManager{get; set;}

        protected override void EntityDied()
        {
            
        }

        protected override void Start(){
          base.Start();
           // InvokeRepeating(nameof(Shoot), 1, 1);
        }
      // private void Shoot(){
      //   Bullet bullet = Instantiate(bulletGO, transform.position, transform.rotation).GetComponent<Bullet>();
      //   Vector2 direction = nPCManager.NearestNPCPosition(this.transform.position) - (Vector2)transform.position;
      //   bullet.Init(direction.normalized);
      // }
    }

}
