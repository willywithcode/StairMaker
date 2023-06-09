using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildBrick : EnemyBaseState 
{

    private Bridge _bridge;
    private GameObject bridge;

    public override void EnterState(Enemy enemy)
    {
        enemy.currentState = this;
        enemy.checkFind = false;
    }
    public override void OnUpdate(Enemy enemy)
    {
        enemy.checkBrick();
    }
    public override void OnTriggerEnter(Enemy enemy, Collider other)
    {

        
        if (other.name.StartsWith("Ground"))
        {
            enemy.ground = other.GetComponent<Ground>();
            enemy.groundState = other.gameObject;
        }
    }
}
