using System.Collections;
using System.Collections.Generic;
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

        void Start(){
            navMeshAgent = GetComponent<NavMeshAgent>();
            navMeshAgent.updateRotation = false;
            navMeshAgent.updateUpAxis = false;
            navMeshAgent.SetDestination(target);
            navMeshAgent.speed = speed;
        }
        void Update(){
           // transform.position -= speed * transform.right * Time.deltaTime;
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
