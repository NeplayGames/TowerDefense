using System.Collections;
using System.Collections.Generic;
using TowerDefense;
using UnityEngine;

namespace TowerDefense.NPC
{
    public class IdleState : IState
    {
        public void Enter()
        {
           Debug.Log("Enter Idle");
        }

        public void Exit()
        {
            Debug.Log("Exit Idle");
            
        }

        public void Update()
        {
        }
    }

     public class RunState : IState
    {
        public void Enter()
        {
           Debug.Log("Enter Run");
        }

        public void Exit()
        {
            Debug.Log("Exit Run");
            
        }

        public void Update()
        {
        }
    }
}
