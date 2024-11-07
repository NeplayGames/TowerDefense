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
    [SerializeField] private int numberOfNPC = 10;
    [SerializeField] private BaseTower baseTower;
    private NPCManager nPCManager;
   public static GameManager Instance;
   private int NPCInstantiated = 0;
   public bool isMute{ get; set;}
    void Start()
    {
        nPCManager = new NPCManager(nPCDatabase, startingPoint);
        if(GameManager.Instance != null){
            Destroy(this.gameObject);
        }
        foreach(var tow in towers){
            tow.nPCManager = nPCManager;
            tow.gameObject.SetActive(true);
        }
        Instance = this;
        InvokeRepeating(nameof(InstantiateNPC), 1, 3);
        baseTower.gameOverEvent += GameOver;
    }

    private void GameOver(){
        baseTower.gameOverEvent -= GameOver;
        Time.timeScale = 0;
    }
    private void InstantiateNPC(){
        if(NPCInstantiated == numberOfNPC)return;
        NPCInstantiated++;
        nPCManager.InitializeNPC();
    }
    void Update(){
       // Instantiate(this.gameObject);
    }
}

}
