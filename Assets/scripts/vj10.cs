using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vj10 : MonoBehaviour
{
    public float input { get; set; }
    public float scale;
    public Transform cube;

    public GameObject[] boxes;

    public float WaitN = 3f;
    public float WaitD = 3f;
    public int shapN = 0;

    // Start is called before the first frame update
    void Start()
    {
        scale = 1;

        boxes = new GameObject[transform.childCount];

        for (int i = 0; i < boxes.Length; i++)
        {
            boxes[0] = transform.GetChild(0).gameObject;
            boxes[1] = transform.GetChild(1).gameObject;
            boxes[2] = transform.GetChild(2).gameObject;
            boxes[3] = transform.GetChild(3).gameObject;
            boxes[4] = transform.GetChild(4).gameObject;
            boxes[5] = transform.GetChild(5).gameObject;
            boxes[6] = transform.GetChild(6).gameObject;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);

        //Vector3 axis = new Vector3(0f, 1f, 1f);
        //float angle = 45f * Time.deltaTime;
        //Quaternion q = Quaternion.AngleAxis(angle, axis);
        //this.transform.rotation = q * this.transform.rotation;

        var localScale = cube.localScale;
        localScale.y = (input * 0.25f) + scale;
        localScale.x = (input * 0.25f) + scale;
        localScale.z = (input * 0.25f) + scale;
        cube.localScale = localScale;



        //if (input > .5f)
        //{
        //    iTween.RotateTo(gameObject, iTween.Hash("z", 180f, "time", .5f, "delay", .000001f));
        //}


        var b1 = boxes[1].transform.localScale;
        var b2 = boxes[2].transform.localScale;
        var b3 = boxes[3].transform.localScale;
        var b4 = boxes[4].transform.localScale;
        var b5 = boxes[5].transform.localScale;
        var b6 = boxes[6].transform.localScale;

        if (WaitN > 0f)
        {
            WaitN -= Time.deltaTime;
        }
        else
        {
            WaitN = WaitD;
            shapN++;

            if (shapN > 7)
            {
                shapN = 0;
            }
        }
        if (shapN == 0)
        {
            b1 = Vector3.Lerp(b1, new Vector3(b1.x, 1.5f, b1.z), Time.deltaTime);
            boxes[1].transform.localScale = b1;

            b2 = Vector3.Lerp(b2, new Vector3(.7f, b2.y, .7f), Time.deltaTime);
            boxes[2].transform.localScale = b2;

            b3 = Vector3.Lerp(b3, new Vector3(.7f, b3.y, .7f), Time.deltaTime);
            boxes[3].transform.localScale = b3;

            
        }
        if (shapN == 1)
        {
            b1 = Vector3.Lerp(b1, new Vector3(b1.x, -1.5f, b1.z), Time.deltaTime);
            boxes[1].transform.localScale = b1;
        }
        if (shapN == 2)
        {
            b1 = Vector3.Lerp(b1, new Vector3(b1.x, .5f, b1.z), Time.deltaTime);
            boxes[1].transform.localScale = b1;


            b2 = Vector3.Lerp(b2, new Vector3(1.4f, b2.y, 1.4f), Time.deltaTime);
            boxes[2].transform.localScale = b2;

            b3 = Vector3.Lerp(b3, new Vector3(1.4f, b3.y, 1.4f), Time.deltaTime);
            boxes[3].transform.localScale = b3;
        }
        if (shapN == 3)
        {
            b2 = Vector3.Lerp(b2, new Vector3(-1.4f, b2.y, -1.4f), Time.deltaTime);
            boxes[2].transform.localScale = b2;

            b3 = Vector3.Lerp(b3, new Vector3(-1.4f, b3.y, -1.4f), Time.deltaTime);
            boxes[3].transform.localScale = b3;

        }
        if (shapN == 4)
        {
            b1 = Vector3.Lerp(b1, new Vector3(0,0, 0), Time.deltaTime);
            boxes[1].transform.localScale = b1;

            b2 = Vector3.Lerp(b2, new Vector3(0, 0, 0), Time.deltaTime);
            boxes[2].transform.localScale = b2;

            b3 = Vector3.Lerp(b3, new Vector3(0, 0, 0), Time.deltaTime);
            boxes[3].transform.localScale = b3;

            b4 = Vector3.Lerp(b4, new Vector3(1.5f, 1.5f, 1.5f), Time.deltaTime);         
            boxes[4].transform.localScale = b4;
        }

        if (shapN == 5)
        {

            b4 = Vector3.Lerp(b4, new Vector3(0f, 0f, 0f), Time.deltaTime);
            boxes[4].transform.localScale = b4;
            b5 = Vector3.Lerp(b5, new Vector3(1.5f, 1.5f, 1.5f), Time.deltaTime);            
            boxes[5].transform.localScale = b5;

        }

        if (shapN == 6)
        {

            b5 = Vector3.Lerp(b5, new Vector3(0f, 0f, 0f), Time.deltaTime);
            boxes[5].transform.localScale = b5;
            b6 = Vector3.Lerp(b6, new Vector3(1.5f, 1.5f, 1.5f), Time.deltaTime);
            boxes[6].transform.localScale = b6;

        }

        if (shapN == 7)
        {
            b1 = Vector3.Lerp(b1, new Vector3(1.5f, 0.5f, 1.5f), Time.deltaTime);
            boxes[1].transform.localScale = b1;

            b2 = Vector3.Lerp(b2, new Vector3(0, 0, 0), Time.deltaTime);
            boxes[2].transform.localScale = b2;

            b3 = Vector3.Lerp(b3, new Vector3(0, 0, 0), Time.deltaTime);
            boxes[3].transform.localScale = b3;

            b6 = Vector3.Lerp(b6, new Vector3(0f, 0f, 0f), Time.deltaTime);
            boxes[6].transform.localScale = b6;
        }
    }
}
