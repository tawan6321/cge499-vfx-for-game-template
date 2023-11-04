using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 10;
    float horizontal;
    float vertical;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(horizontal, vertical, 0);
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
