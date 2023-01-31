using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinePathScript : MonoBehaviour
{
    Vector3 start_position;
    float x_off;

    // Start is called before the first frame update
    void Start()
    {
        x_off = 0.0f;
        start_position = transform.position - (new Vector3(0.0f, 0.0f, 0.0f));
    }

    // Update is called once per frame
    void Update()
    {
        x_off = x_off + (1.0f * Time.deltaTime);
        transform.position = start_position + new Vector3(x_off, Mathf.Sin(x_off*Mathf.PI), 0.0f);
    }
}
