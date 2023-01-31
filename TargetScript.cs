using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        float horiz_input = Input.GetAxis("Horizontal");
        float vert_input = Input.GetAxis("Vertical");

        Vector3 mov_dir = new Vector3(horiz_input, vert_input, 0.0f);
        float magnitude = Mathf.Clamp01(mov_dir.magnitude);
        mov_dir.Normalize();

        transform.Translate(mov_dir * speed * magnitude * Time.deltaTime);
    }
}
