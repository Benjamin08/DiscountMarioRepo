using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour {

    //private BoxCollider2D Flag_Collider;
    // Use this for initialization
    public bool isHit = false;
    private GameObject Player;

    public GameObject startMarker;
    public GameObject endMarker;
    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;
    float distCovered;
    float fracJourney;

    void Start () {
        // Flag_Collider.GetComponent<BoxCollider2D>();
        Player = GameObject.FindGameObjectWithTag("Player");
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
        if (Flag_Player.gameObject.tag == "Player")
        {
            isHit = true;
            Debug.Log("flag");
           
        }
    }
}
