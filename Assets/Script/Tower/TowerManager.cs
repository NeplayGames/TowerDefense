using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace TowerDefense.TOWER
{
    public class TowerManager : EntityManager
    {
        private readonly TowerDB towerDB;
        private readonly Tilemap groundTile;
        private int towerPlaced = 0;
        public TowerManager(TowerDB towerDB, Tilemap groundTile){
            this.towerDB = towerDB;
            this.groundTile = groundTile;
            Tower.entityDied += TowerIsDead;
        }

        private void TowerIsDead(GameObject tower)
        {
            entities.Remove(tower.transform);
            GameObject.Destroy(tower);
        }

        public void Tick(){
            if(Input.GetMouseButtonDown(0))
            {
                PlaceTower();
            };
        }

        private void PlaceTower()
        {
            if(towerPlaced == 5) return;
            towerPlaced++;         
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 positionOnGrid = groundTile.WorldToCell(worldMousePosition);
            GameObject tower = GameObject.Instantiate(towerDB.archeryTower, positionOnGrid, Quaternion.identity);
            entities.Add(tower.transform);
        }
    }

}
