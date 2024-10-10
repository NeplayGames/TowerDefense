using System;
using System.Collections;
using System.Collections.Generic;
using TowerDefense;
using TowerDefense.NPC;
using UnityEngine;

public class NPCStateMachine : MonoBehaviour
{
    private RunState runState;
    private IdleState idleState;
    private IState currentState;
    void Start()
    {
        runState = new();
        idleState = new();
        InvokeRepeating(nameof(ChangeCurrentState), 1, 1);
    }
    void Update(){
        currentState?.Update();
    }
    void ChangeCurrentState(){
        currentState?.Exit();
        if(currentState == runState){
            currentState = idleState;
        }else{
            currentState = runState;
        }
        currentState.Enter();
    }

   
}
