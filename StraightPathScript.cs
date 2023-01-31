using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightPathScript : MonoBehaviour
{
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
