using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float horizontalInput;
    [SerializeField]
    float speed = 10.0f;

    [SerializeField]
    float boundaryLimt=20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -boundaryLimt)
            transform.position = new Vector3(-boundaryLimt, transform.position.y, transform.position.z);

        if (transform.position.x > boundaryLimt)
            transform.position = new Vector3(boundaryLimt, transform.position.y, transform.position.z);


        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        
    }
}
