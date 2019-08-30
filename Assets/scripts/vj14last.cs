using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vj14last : MonoBehaviour
{

    public float speed;
    public float radius;
    public float zPosition;
    float x;
    float y;
    float z;


    //public float degree;
    //public float scale;
    //public int number;

    //public float angle;
    //public float r;



    private TrailRenderer _trailLenderer;

    // Use this for initialization
    void Start()
    {
        speed = 3.75f;
        radius = 16f;

        zPosition = 0f;

        _trailLenderer = GetComponent<TrailRenderer>();

         //angle = number * (degree * Mathf.Deg2Rad);

         //r = scale * Mathf.Sqrt(number);
    }

    // Update is called once per frame
    void Update()
    {
        x = radius * Mathf.Sin(Time.time * speed);
        z = zPosition;
        y = radius * Mathf.Cos(Time.time * speed);

        transform.position = new Vector3(x, y, z);

        //x = r * Mathf.Sin(Time.time * angle);
        //z = zPosition;
        //y = r * Mathf.Cos(Time.time * angle);

        //transform.position = new Vector3(x, y, z);
    }
}
