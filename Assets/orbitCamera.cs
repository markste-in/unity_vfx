using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbitCamera : MonoBehaviour
{
    public Transform target;
    public float anglePerTimestep =0.2f;
    public float ellipseAmount = 5;
    public Vector3 ellipseOffset = new Vector3(2, 0, 0);

    bool RotationStarted = false;
    void startRotation() => RotationStarted = true;

    void Start()
    {
        Invoke("startRotation", 30f);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (RotationStarted)
        {
            //The sin/cos of the scaledTime will go exactly once from -1 to 1 per roation
            float TimeDilationFactor = (4 * Mathf.PI * anglePerTimestep) / (360 * Time.fixedDeltaTime);
            float scaledTime = (Time.fixedTime * TimeDilationFactor);


            Vector3 offset = Vector3.forward * Mathf.Sin(scaledTime) * ellipseAmount + Vector3.left * Mathf.Cos(scaledTime) * ellipseAmount;

            transform.LookAt(target);
            transform.RotateAround(target.position + offset + ellipseOffset, new Vector3(0, 1, 0), anglePerTimestep);
        }

    }


}
