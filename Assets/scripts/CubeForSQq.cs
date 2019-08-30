using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CubeForSQq : MonoBehaviour
{



    public static float Radius = 100;

    public static int round = 20;

    [SerializeField]
    int NUM = 300;
    [SerializeField]
    public GameObject CubePrefab;
    //[SerializeField]
    //public int round = 0;
    [SerializeField]
    public float linermin = 0;
    [SerializeField]
    public float linermax = 180;

    float speed = 1f;

    public GameObject[] PrefabsCube;


    // Start is called before the first frame update
    void Start()
    {
        PrefabsCube = new GameObject[NUM];

        //float randTheta = Random.Range(0,360);
        //float randPhi = Random.Range(0, 360);

        for (int i = 0; i < NUM; i++)
        {

            PrefabsCube[i] = Instantiate(CubePrefab, new Vector3(0, 0, 0), Quaternion.identity);

        }

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 center = Vector3.zero;


        foreach (var cub in PrefabsCube)
        {
            speed++;
            

            

            float randTheta = Random.Range(linermin, linermax);

            //float randPhi = speed*0.02f;
            float randPhi = speed * round;
            //float randPhi = speed*2f;
            if (randPhi > 360)
            {
                speed = 0;
            }


            cub.transform.position = new Vector3(Radius * Mathf.Sin(Mathf.Deg2Rad * randTheta) * Mathf.Cos(Mathf.Deg2Rad * randPhi),
                                                 Radius * Mathf.Sin(Mathf.Deg2Rad * randTheta) * Mathf.Sin(Mathf.Deg2Rad * randPhi),
                                                 Radius * Mathf.Cos(Mathf.Deg2Rad * randTheta));



        }



    }
}
