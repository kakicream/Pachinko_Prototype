using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    protected Rigidbody obstacleRb;
    protected Vector3 obstaclePos;

    protected float xPos;
    protected float yPos;
    [SerializeField] protected float xSpeed;
    [SerializeField] protected float ySpeed;
    [SerializeField] protected float xRange;
    [SerializeField] protected float yRange;

    void Start()
    {
        obstacleRb = GetComponent<Rigidbody>();
        obstaclePos = transform.position;
    }

    public virtual float XMoveCalc()
    {
        return xPos;
    }
    public virtual float YMoveCalc()
    {
        return yPos;
    }

    void Update()
    {
        Vector3 newPos = obstaclePos;
        newPos.x += XMoveCalc();
        newPos.y += YMoveCalc();
        transform.position = newPos;
    }
}
