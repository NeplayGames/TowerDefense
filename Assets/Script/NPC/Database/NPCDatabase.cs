using UnityEngine;
using TowerDefense.NPC;
namespace TowerDefense.Database
{
    [CreateAssetMenu(menuName = "Database/NPC DB", fileName = "NPC DB")]
    public class NPCDatabase : ScriptableObject
    {
        [field: SerializeField] public Npc[] nPC{ get; private set; }
    }

}
