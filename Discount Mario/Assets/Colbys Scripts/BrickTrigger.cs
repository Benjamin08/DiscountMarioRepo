using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickTrigger : MonoBehaviour {

    public GameObject Brick_Trigger;
    private BoxCollider2D Brick_TriggerBoxCollider;
	// Use this for initialization
	void Start () {
        //Brick_Trigger.GetComponent<BoxCollider2D>();
        Brick_TriggerBoxCollider = Brick_Trigger.GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
