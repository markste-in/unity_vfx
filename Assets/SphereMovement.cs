using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public float rotationalSpeed= 15;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(rotationalSpeed * Time.fixedDeltaTime,  rotationalSpeed * Time.fixedDeltaTime , rotationalSpeed * Time.fixedDeltaTime);
        
    }
}
