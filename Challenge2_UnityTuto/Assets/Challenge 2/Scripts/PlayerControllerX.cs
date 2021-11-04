using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
  
    private float startDelay = 2.0f;
    private float spawnInterval=30.0f;
    float health = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvokeRepeating("SpownDogs", startDelay, spawnInterval);
         
        }
    }

    void SpownDogs()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
  
    }
}
