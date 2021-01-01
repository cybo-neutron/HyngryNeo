using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stationaryEnemy : Enemy
{

    public override void Start()
    {
        base.Start();
        type = types.stationary;
        attackSkill = attackSkills.shooting;
        attackingDistance = chasingDistance;
    }


    public override void idle()
    {

    }
    public override void patrol()
    {
        
    }

    public override void chase()
    {
        
    }

    public override void attack()
    {
        
    }
}
