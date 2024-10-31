using System.Collections;
using System.Collections.Generic;
using TowerDefense.Database;
using TowerDefense.NPC;
using TowerDefense.TOWER;
using UnityEngine;

namespace TowerDefense{
public class GameManager : MonoBehaviour
{
    //Temp Testing variable for towers
    [SerializeField] private Tower[] towers;
    [SerializeField] private NPCDatabase nPCDatabase;
    [SerializeField] private Transform startingPoint;
    private NPCManager nPCManager;
   public static GameManager Instance;
   public bool isMute{ get; set;}
    void Start()
    {
        nPCManager = new NPCManager(nPCDatabase, startingPoint);
        if(GameManager.Instance != null){
        print(Instance.gameObject.name);
            Destroy(this.gameObject);
        }
        foreach(var tow in towers){
            tow.nPCManager = nPCManager;
            tow.gameObject.SetActive(true);
        }
        print("This is a game");
        Instance = this;
        InvokeRepeating(nameof(InstantiateNPC), 1, 1);
    }

    private void InstantiateNPC(){
        nPCManager.InitializeNPC();
    }
    void Update(){
       // Instantiate(this.gameObject);
    }
}

}
