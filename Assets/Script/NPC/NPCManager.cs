using System.Collections;
using System.Collections.Generic;
using TowerDefense.Database;
using UnityEngine;

namespace TowerDefense.NPC
{

    public class NPCManager
    {
        private List<Transform> nPCs= new();
       private NPCDatabase nPCDatabase;
        private Transform startingPoint;
       public NPCManager(NPCDatabase nPCDatabase, Transform startingPoint){
        this.nPCDatabase = nPCDatabase;
        this.startingPoint = startingPoint;
       }

        public void InitializeNPC(){
           nPCs.Add(GameObject.Instantiate(this.nPCDatabase.nPC[Random.Range(0, 
            this.nPCDatabase.nPC.Length)].gameObject,startingPoint.position,startingPoint.rotation).transform);
        }

        public Vector2 NearestNPCPosition(Vector3 towerPosition){
            float minDistance = Mathf.Infinity;
            Vector2 result = Vector2.zero;
            foreach(Transform t in nPCs){
                float distance = Vector2.Distance(t.position, towerPosition);
                if(distance < minDistance){
                    minDistance = distance;
                    result = t.position;
                }
            }
            return result;
        }
    }

}