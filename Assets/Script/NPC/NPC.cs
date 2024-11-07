using System;
using System.Collections;
using System.Collections.Generic;
using TowerDefense.TOWER;
using UnityEngine;
using UnityEngine.AI;

namespace TowerDefense.NPC{
    public abstract class Npc : Entity
    {
        [field:Header("Speed per second")]
       [field:SerializeField] protected int speed {get; set;} = 5;
      
        //ToDo:
        //Maybe this is something bullet and other things will handle
        [field:SerializeField]protected int damageDealt {get; set;}
        [field:SerializeField]protected ENPCType eNPCType{get; set;}
        //ToDo
        //
        protected Vector2 target = new Vector2(-14.6f, 3.6f);
        private NavMeshAgent navMeshAgent;
        public static event Action<GameObject> NPCDied; 
        protected override void Start(){
            base.Start();
            navMeshAgent = GetComponent<NavMeshAgent>();
            navMeshAgent.updateRotation = false;
            navMeshAgent.updateUpAxis = false;
            navMeshAgent.SetDestination(target);
            navMeshAgent.speed = speed;
        }

        protected override void EntityDied()
        {
            NPCDied?.Invoke(this.gameObject);
        }
        void Update(){
           // transform.position -= speed * transform.right * Time.deltaTime;
        }

        void OnCollisionEnter2D(Collision2D collision){
            if(collision.collider.TryGetComponent<Bullet>(out Bullet bullet)){
                Destroy(bullet.gameObject);
                ReduceHealth(10);
            }
        }
    }

    public enum ENPCType{
        Tank = 0,
        Monsters = 1,
        Artillery = 2
    }

    // public enum ERarity{
    //     Common = 0, 
    //     Rare = 1,
    //     Epic = 3,
    //     Legendary = 2
    // }
}
