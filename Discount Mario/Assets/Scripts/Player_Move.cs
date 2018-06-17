using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{


    public int playerSpeed = 1;
    private bool facingRight = false;
    public int playerJumpPower = 125;
    public float moveX;

	private Animator anim;

    // Use this for initialization
    void Start()
    {
        FlipPlayer();
		anim = this.gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        //controls
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        if (moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
			anim.SetBool("isStopped", false);
        }
        else if (moveX > 0.0f && facingRight == true)
        {
            FlipPlayer();
			anim.SetBool("isStopped", false);
        }

		else if(moveX == 0)
			anim.SetBool("isStopped", true);

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);

    }
}