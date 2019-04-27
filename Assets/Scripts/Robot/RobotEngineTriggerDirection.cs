using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotEngineTriggerDirection : RobotTrigger
{
    public RobotEngine engine;
    public float amount;
    public override void Use()
    {
        engine.angle += amount;
        engine.Turn();
    }
}
