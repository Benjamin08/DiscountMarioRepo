using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenyousalecktScreen : MonoBehaviour {
    public int index = 0;
    public int toadleOpshons = 3;
    public float Ofiset = 120f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (index < toadleOpshons-1)
            {
                index++;
                Vector2 position = transform.position;
                position.y += Ofiset;
                transform.position = position;

            }

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (index > 0)
            {
                index--;
                Vector2 position = transform.position;
                position.y -= Ofiset;
                transform.position = position;

            }

        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (index == 0)
            {
                SceneManager.LoadScene("Start");
            }
            if (index == 1)
            {
                SceneManager.LoadScene("Skins");

            }
            if (index == 2)
            {
                SceneManager.LoadScene("Opshons");

            }


        }

    }
}
