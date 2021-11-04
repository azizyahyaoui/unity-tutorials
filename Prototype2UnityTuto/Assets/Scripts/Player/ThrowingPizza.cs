using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingPizza : MonoBehaviour
{

    [SerializeField] GameObject projectTilePrefab;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectTilePrefab, transform.position, projectTilePrefab.transform.rotation);
        }
    }
}
