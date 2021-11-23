using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle1 : ObstacleController
{
    public override float XMoveCalc()
    {
        xPos = Mathf.Sin(Time.time * xSpeed) * xRange;
        return base.XMoveCalc();
    }
    public override float YMoveCalc()
    {
        yPos = Mathf.Cos(Time.time * ySpeed) * yRange;
        return base.YMoveCalc();
    }
}
