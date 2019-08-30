using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChenge : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;

    // Start is called before the first frame update
    void Start()
    {
        Camera1 = GameObject.Find("Main Camera1");
        Camera2 = GameObject.Find("Main Camera2");

        Camera2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (Camera1.activeSelf)
            {
                Camera1.SetActive(false);
                Camera2.SetActive(true);
            }
        }

        if (Input.GetKeyDown("0"))
        {
            if (Camera2.activeSelf)
            {
                Camera2.SetActive(false);
                Camera1.SetActive(true);
            }
        }

    }
}
