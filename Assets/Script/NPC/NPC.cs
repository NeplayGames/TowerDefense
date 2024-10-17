using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace TowerDefense.NPC{
    public abstract class NPC : MonoBehaviour
    {
        [field:Header("Speed per second")]
       //[field:SerializeField] protected int speed {get; set;} = 5;
        [field:SerializeField]protected float health {get; set;}
        [field:SerializeField]protected int attackRate {get; set;}
        [field:SerializeField]protected int damageDealt {get; set;}
        [field:SerializeField]protected ENPCType eNPCType{get; set;}
        [field:SerializeField]protected Transform target{get; set;}
        private NavMeshAgent navMeshAgent;

        void Start(){
            navMeshAgent = GetComponent<NavMeshAgent>();
            navMeshAgent.updateRotation = false;
            navMeshAgent.updateUpAxis = false;
            navMeshAgent.SetDestination(target.position);
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
