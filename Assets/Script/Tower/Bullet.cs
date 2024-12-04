using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense.TOWER
{
    public class Bullet : MonoBehaviour
    {
       [field: SerializeField] public EBulletType eBulletType{ get; private set; }
        private Vector3 direction;
        public void Init(Vector2 direction){
            this.direction = direction;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;    
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }

        void Update(){
            transform.position += direction* Time.deltaTime * 16;
        }

        public int Damage(){
            return Random.Range(2, 14);
        }
    }

    public enum EBulletType{
        ENPC = 0,
        ETower = 1
    }
}

