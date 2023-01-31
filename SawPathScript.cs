using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawPathScript : MonoBehaviour
{
    Vector3 arrow_vector;
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        arrow_vector = new Vector3(0.0f, 1.0f, 1.0f);
        speed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(arrow_vector * speed * Time.deltaTime);
        if (transform.position.y > 1.0f) {
            transform.position = new Vector3(transform.position.x, -1.0f, 0.0f);
        }
    }
}
