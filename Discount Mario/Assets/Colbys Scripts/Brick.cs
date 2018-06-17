using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
   

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D Brick_Player)
    {
        if (Brick_Player.gameObject.tag == "Player")
        {
            Debug.Log("Test");
        }
    }
}
