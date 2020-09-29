using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float turnSpeed = 30.0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = false;
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(new Vector3(verticalInput, horizontalInput, 0) * turnSpeed * Time.deltaTime, Space.Self);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = transform.forward * speed;
    }
}
