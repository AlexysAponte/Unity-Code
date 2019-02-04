using UnityEngine;

public class physics : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(-transform.forward * thrust);
        rb.useGravity = true;
    }
}