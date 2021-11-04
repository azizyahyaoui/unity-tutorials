using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacleManagerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject pefabeObstacle;
    private Vector3 spownPos = new Vector3(26f, 0, 0);
    private float startDelay = 3;
    private int spownRate;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        spownRate = Random.Range(1, 3);
        InvokeRepeating("SpownObstacle", startDelay, spownRate);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpownObstacle()
    {
        if (playerController.gameOver == false)
        {
            Instantiate(pefabeObstacle, spownPos, pefabeObstacle.transform.rotation);
        }
    }
}
