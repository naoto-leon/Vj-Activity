using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vj12 : MonoBehaviour
{
    public float input { get; set; }

    // Start is called before the first frame update
    void rotatex()
    {
        iTween.RotateTo(gameObject, iTween.Hash("x", 180f, "time", .5f, "delay",.000001f));

    }

    void rotatey()
    {
        iTween.RotateTo(gameObject, iTween.Hash("y", 180f, "time", .5f, "delay", .000001f));
    }

    void rotatez()
    {
        iTween.RotateTo(gameObject, iTween.Hash("z", 180f, "time", .5f, "delay", .000001f));
    }


    // Update is called once per framea
    void Update()
    {

		if (Input.GetKeyDown("a"))
		{
			rotatex();

		}

        if (Input.GetKeyDown("s"))
        {
            rotatey();
        }


        if (Input.GetKeyDown("d"))
        {
            rotatez();
        }

    }
}
