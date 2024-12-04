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
            InvokeRepeating(nameof(Shoot), 1, attackTime);
        }
      private void Shoot(){
        Vector2 nearestNPCLocation = nPCManager.NearestEntityPosition(this.transform.position);
        if(nearestNPCLocation == Vector2.zero)return;
        Bullet bullet = Instantiate(bulletGO, transform.position, transform.rotation).GetComponent<Bullet>();
        Vector2 direction =nearestNPCLocation  - (Vector2)transform.position;
        bullet.Init(direction.normalized);
      }

      void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.TryGetComponent<Bullet>(out Bullet bullet))
            {
                if(bullet.eBulletType == EBulletType.ETower) return;
                Destroy(bullet.gameObject);
                ReduceHealth(bullet.Damage());
            }
        }
    }

}
