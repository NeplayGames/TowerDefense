using TowerDefense.Database;
using UnityEngine;

namespace TowerDefense.NPC
{
    public class NPCManager : EntityManager
    {
        private NPCDatabase nPCDatabase;
        private Transform startingPoint;
        public NPCManager(NPCDatabase nPCDatabase, Transform startingPoint)
        {
            this.nPCDatabase = nPCDatabase;
            this.startingPoint = startingPoint;
            Npc.entityDied += NPCDied;
        }

        private void NPCDied(GameObject npc)
        {
            entities.Remove(npc.transform);
            GameObject.Destroy(npc);
        }

        public void InitializeNPC()
        {
            entities.Add(GameObject.Instantiate(this.nPCDatabase.nPC[Random.Range(0,
             this.nPCDatabase.nPC.Length)].gameObject, startingPoint.position, startingPoint.rotation).transform);
        }
    }
}