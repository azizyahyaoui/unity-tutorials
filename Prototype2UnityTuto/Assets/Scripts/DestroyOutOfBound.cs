using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    
    private float topBoundaryLimt = 30f;
    private float bottomBoundaryLimt = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBoundaryLimt)
            Destroy(gameObject);

        else if (transform.position.z < bottomBoundaryLimt)
            Destroy(gameObject);
    }
}
