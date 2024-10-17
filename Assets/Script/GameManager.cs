using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense{
public class GameManager : MonoBehaviour
{
   public static GameManager Instance;
   public bool isMute{ get; set;}
    void Start()
    {
        if(GameManager.Instance != null){
        print(Instance.gameObject.name);
            Destroy(this.gameObject);
        }
        
        print("This is a game");
        Instance = this;
    }

    void Update(){
       // Instantiate(this.gameObject);
    }
}

}
