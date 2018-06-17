using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player_Health : MonoBehaviour {

    public int health;
    public bool hasDied;

    void Start()
    {
        hasDied = false;
    }

    void Update()
    {
        if (gameObject.transform.position.y < -7)
        {
            hasDied = true;
        }
        if (hasDied == true)
        {
            StartCoroutine("Die");
        }
    }

    IEnumerator Die()
    {
        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene("Alex Test Scene");

    }
}
