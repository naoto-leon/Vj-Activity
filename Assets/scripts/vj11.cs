using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vj11 : MonoBehaviour
{
    public float input { get; set; }
    //public AudioSpectrum spectrum;
    public GameObject[] point;

    public GameObject obj;
    private LineRenderer lineRenderer;



    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = obj.GetComponent<LineRenderer>();
        lineRenderer.SetWidth(.2f, .2f);
        lineRenderer.SetColors(Color.white, Color.white);

        point = new GameObject[transform.childCount];
    }

    // Update is called once per frame
    void Update()
    {
        float angleDiff = 360f / (float)point.Length;
       


        for (int i = 1; i < point.Length; i = i + 2)
        {
            float angle = ( angleDiff * i) * Mathf.Deg2Rad;

            point[i] = transform.GetChild(i).gameObject;
            Vector3 Pos = point[i].transform.position;

            lineRenderer.SetPosition(i, Pos);


            //Pos.y = (input * -2);

            Pos.x = (5f+(input*3) ) * Mathf.Cos(angle);
            Pos.y = (5f-(input * 3)) * Mathf.Sin(angle);

            point[i].transform.position = Pos;
        }

        for (int i = 0; i < point.Length; i = i + 2)
        {
            float angle = ( angleDiff * i) * Mathf.Deg2Rad;

            point[i] = transform.GetChild(i).gameObject;
            Vector3 Pos = point[i].transform.position;

            lineRenderer.SetPosition(i, Pos);


            //Pos.y = (input * +2);

            Pos.x = (5f- (input * 3)) * Mathf.Cos(angle);
            Pos.y = (5f+ (input * 3)) * Mathf.Sin(angle);

            point[i].transform.position = Pos;
        }
    }
}