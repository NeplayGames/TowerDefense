using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense.TOWER
{
    public class ArcheryTower : Tower
    {
         [SerializeField] private GameObject bulletGO;


        protected override void Start(){
          base.Start();
            InvokeRepeating(nameof(Shoot), 1, 1);
        }
      private void Shoot(){
        Vector2 nearestNPCLocation = nPCManager.NearestNPCPosition(this.transform.position);
        if(nearestNPCLocation == Vector2.zero)return;
        Bullet bullet = Instantiate(bulletGO, transform.position, transform.rotation).GetComponent<Bullet>();
        Vector2 direction =nearestNPCLocation  - (Vector2)transform.position;
        bullet.Init(direction.normalized);
      }
    }

}
