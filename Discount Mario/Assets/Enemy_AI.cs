using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour {

    // Use this for initialization
    public float enemySpeed = 1;
    public float patrolMinX;    
    public float patrolMaxX;
    public float originalLocation;
    public bool isPatrolling;
    public int direction; 



	void Start ()
    {
        DetermineFirstDirection();
        originalLocation = gameObject.transform.position.x;

    }
	
	// Update is called once per frame
	void Update ()
    {
        EnemyMove();
    }
    bool PatrolRoute()
    {
        return true;
    }

    void EnemyMove()
    {  
        

        //if (gameObject.GetComponent<Rigidbody2D>().velocity.x < 0)
        //{
        //    direction = -1;
        //}
        //else direction = 1;

        if (isPatrolling)
        {
            if(gameObject.transform.position.x > (originalLocation + patrolMaxX) ||
                gameObject.transform.position.x < (originalLocation - patrolMinX))
            {
                ChangeDirection();
                Debug.Log("Patrol Route finished reseting");
            }
        }
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(direction * enemySpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);

    }

    void DetermineFirstDirection()
    {
        
        direction = Random.Range(0, 1);
        if (direction == 0)
        {
            direction = -1;
        }
        Debug.Log(direction);

        
    }

    void ChangeDirection()
    {


        Debug.Log("current direction: " + direction);
        if (direction == 1)
        {
            direction = -1;
        }       
        else direction = 1;

        Debug.Log("direction is now" + direction);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enemy ai has collided with " + collision.collider.name);
        if (collision.gameObject.tag == "Wall")

        {
            ChangeDirection();
        }
    }

    //void OnControllerColliderHit(ControllerColliderHit hit)
    //{

    //    if (hit.collider.gameObject.tag == "Wall")
    //    {

    //        Vector3 eulerAngles = transform.rotation.eulerAngles;

    //        // Set the altered rotation back
    //        transform.rotation = Quaternion.Euler(eulerAngles * -1);

    //        Debug.Log("HIT WALL - ROTATING!"); // Display it in UI
    //    }
    //}
}
