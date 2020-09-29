using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateZ : MonoBehaviour
{
    [SerializeField] private float turnSpeed = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float currentRotationZ = transform.localRotation.z;
        float targetRotationZ = horizontalInput * 20;

        //transform.Rotate(
        //    transform.forward, 
        //    Mathf.Lerp(currentRotationZ, targetRotationZ, turnSpeed * Time.deltaTime), 
        //    Space.Self);

        transform.localRotation = Quaternion.Euler(
            Mathf.Lerp(currentRotationZ, targetRotationZ, turnSpeed),
            transform.localRotation.eulerAngles.y,
            transform.localRotation.eulerAngles.z);
    }
}
