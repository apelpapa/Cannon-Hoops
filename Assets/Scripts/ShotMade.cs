using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMade : MonoBehaviour
{
    private ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            scoreManager.ballsHeld += 1f;
            Destroy(gameObject);
        }
        if (other.tag == "Hoop")
        {
            scoreManager.score += 1f;
            Destroy(gameObject);
        }
    }
}
