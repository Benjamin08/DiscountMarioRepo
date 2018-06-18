using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour {

    public bool isHit = false;
    private BoxCollider2D FlagTrigger;
    public GameObject startMarker;
    public GameObject endMarker;
    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;
    public GameObject Player;
    float distCovered;
    float fracJourney;
    // Use this for initialization
    void Start () {
        FlagTrigger = GetComponent<BoxCollider2D>();
        //  Player = GameObject.FindGameObjectsWithTag("Player");
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.transform.position, endMarker.transform.position);
    }
	
	// Update is called once per frame
	void Update () {
		if(isHit)
        {
            distCovered = (Time.time - startTime) * speed;
            fracJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(startMarker.transform.position, endMarker.transform.position, fracJourney);
            Player.transform.position = Vector3.Lerp(startMarker.transform.position, endMarker.transform.position, fracJourney);
        }
	}

    void OnTriggerEnter2D(Collider2D Flag_Player)
    {
        isHit = true;
    }

}
