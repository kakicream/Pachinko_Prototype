using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle2 : ObstacleController
{
    float xRandomizer;
    float yRandomizer;
    private void Start()
    {

        xRandomizer = Random.Range(0.8f, 1.1f);
        yRandomizer = Random.Range(0.8f, 1.1f);
        obstaclePos = transform.position;
    }


    public override float XMoveCalc()
    {
        xPos = Mathf.Sin(Time.time * xSpeed) * xRange * xRandomizer;
        return base.XMoveCalc();
    }
    public override float YMoveCalc()
    {
        //yPos = Mathf.Cos(Time.time * ySpeed) * yRange * yRandomizer;
        return base.YMoveCalc();
    }
}
