using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public float x, y, z;
    Animator a;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(x, y, 0.02f);
            a.Play("Walk In Place");
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(x, y, -0.02f);
            a.Play("Walk In Place");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(x, -0.5f, z);
            a.Play("Walk In Place");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(x, 0.5f, z);
            a.Play("Walk In Place");
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(x, y, 0.05f);
            a.Play("Run In Place");
        }
        else if (Input.GetKey(KeyCode.R))
        {
            a.Play("Turn Head");
        }
        else if (Input.GetKey(KeyCode.E))
        {
            a.Play("Eat");
        }
        else
        {
            transform.Translate(0, 0, 0);
            a.Play("Idle");
        }
    }
}
