using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense.NPC{
    public abstract class NPC : MonoBehaviour
    {
        [field:Header("Speed per second")]
       [field:SerializeField] protected int speed {get; set;} = 5;
        [field:SerializeField]protected float health {get; set;}
        [field:SerializeField]protected int attackRate {get; set;}
        [field:SerializeField]protected int damageDealt {get; set;}
        [field:SerializeField]protected ENPCType eNPCType{get; set;}

        void Update(){
            transform.position -= speed * transform.right * Time.deltaTime;
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
