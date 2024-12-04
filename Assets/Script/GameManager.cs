using TowerDefense.Database;
using TowerDefense.NPC;
using TowerDefense.TOWER;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace TowerDefense
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private Tilemap groundTile;
        [SerializeField] private NPCDatabase nPCDatabase;
        [SerializeField] private TowerDB towerDB;
        [SerializeField] private Transform startingPoint;
        [SerializeField] private int numberOfNPC = 10;
        [SerializeField] private BaseTower baseTower;
        public NPCManager nPCManager;
        public TowerManager towerManager;
        public static GameManager Instance;
        private int NPCInstantiated = 0;
        public bool isMute { get; set; }
        void Start()
        {
            nPCManager = new NPCManager(nPCDatabase, startingPoint);
            towerManager = new TowerManager(towerDB, groundTile);
            if (GameManager.Instance != null)
            {
                Destroy(this.gameObject);
            }

            Instance = this;
            InvokeRepeating(nameof(InstantiateNPC), 1, 3);
            baseTower.gameOverEvent += GameOver;
        }

        private void GameOver()
        {
            baseTower.gameOverEvent -= GameOver;
            Time.timeScale = 0;
        }
        private void InstantiateNPC()
        {
            if (NPCInstantiated == numberOfNPC) return;
            NPCInstantiated++;
            nPCManager.InitializeNPC();
        }
        void Update()
        {
            towerManager.Tick();
            // Instantiate(this.gameObject);
        }
    }

}
