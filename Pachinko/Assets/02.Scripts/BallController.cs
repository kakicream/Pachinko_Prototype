using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    Rigidbody ballRb; // For collisions with the obstacles

    Vector3 ballPos;
    private bool canMove;
    private float xVec;
    [SerializeField] private float xRange;
    [SerializeField] private float moveSpeed;

    void Start()
    {
        ballPos = transform.position;
        canMove = true;
        ballRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        BallMove();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(1);
        }
    }

    void BallMove()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canMove == true)
        {
            canMove = false;
            ballRb.useGravity = true;
        }

        else if (canMove == true)
        {
            Vector3 currPos = ballPos;
            currPos.x += MoveSpeedCalc();
            transform.position = currPos;
        }
    }

    float MoveSpeedCalc()
    {
        xVec = Mathf.Sin(Time.time * moveSpeed) * xRange;
        return xVec;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BASKET"))
        {
            Destroy(gameObject);
        }
    }
}
