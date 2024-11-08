using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShooter : MonoBehaviour
{
    private ScoreManager scoreManager;
    public GameObject ballPrefab;
    public GameObject shootingOffset;
    public GameObject cannon;
    private Quaternion shootingAngle;
    void Start()
    {
        scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        shootingAngle = cannon.transform.rotation;
        if (scoreManager.ballsHeld > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(ballPrefab, shootingOffset.transform.position, shootingAngle *= Quaternion.Euler(-90, 0, 0));
                scoreManager.ballsHeld -= 1;
            }
        }
    }
}
