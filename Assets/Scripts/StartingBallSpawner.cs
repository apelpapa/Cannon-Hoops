using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingBallSpawner : MonoBehaviour
{
    public float numberStartingBalls = 20f;
    public float startLocationDistance =20f;
    public GameObject startingBall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(numberStartingBalls > 0){
            Instantiate(startingBall, new Vector3(Random.Range(-startLocationDistance, startLocationDistance), 1, Random.Range(-startLocationDistance, startLocationDistance)), startingBall.transform.rotation);
            numberStartingBalls -= 1;
        }
    }
}
