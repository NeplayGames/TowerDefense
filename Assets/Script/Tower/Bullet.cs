using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense.TOWER
{
    public class Bullet : MonoBehaviour
    {
        private Vector3 direction;
        public void Init(Vector2 direction){
            this.direction = direction;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;    
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }

        void Update(){
            transform.position += direction* Time.deltaTime * 16;
        }
    }
}

