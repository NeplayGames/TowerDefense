using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense.TOWER
{
    public class Bullet : MonoBehaviour
    {
        private Vector3 npcLocation;
        private Vector3 initialPosition;
        private float time;
        private float tempTime = 0;
        public void Init(Vector2 npcLocation){
            this.npcLocation = npcLocation;
            this.initialPosition = transform.position;
           // transform.LookAt(npcLocation);
            time = Vector2.Distance(transform.position, npcLocation)/16;
        }

        void Update(){
            transform.position += npcLocation* Time.deltaTime * 16;
            if(tempTime < time){
              // transform.position =  Vector2.Lerp(this.initialPosition, this.npcLocation, tempTime/time);
               tempTime += Time.deltaTime;
            }//else{
               // Destroy(this.gameObject);
            }
        }
    }

