using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene001 : MonoBehaviour
{
    public Rigidbody body;
    public float Force;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    private void LateUpdate()
    {
        var z = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");
        var input = new Vector3(0, y, z);

        body.AddForce(input * Force * Time.smoothDeltaTime);
    }
}
