using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCh : MonoBehaviour
{
    public int Amount = 100;
    public GameObject prefabfish;
    public GameObject[] prefabsFish;

    //public GameObject Boss;
    //public GameObject center;


    public float Turbulence = 0.2f;

    public float Distance;//2以上？と思われる
    public float Distance_hanit = 3f;//ランダム 2以上？と思われる

    // Start is called before the first frame update
    void Start()
    {
        prefabsFish = new GameObject[Amount];

        for (int i = 0; i < Amount; i++)
        {
            prefabsFish[i] = Instantiate(prefabfish, new Vector3(Random.Range(-15f, 15f), Random.Range(45f, 55f), Random.Range(-3f, 3f)), Quaternion.identity);

        }

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 center = Vector3.zero;

        foreach (var children in prefabsFish)
        {
            center += children.transform.position;
        }

        center /= (prefabsFish.Length - 1);


        foreach (var children in prefabsFish)
        {


            Vector3 DirTocenter = (center - children.transform.position).normalized;
            Vector3 direction = (children.GetComponent<Rigidbody>().velocity.normalized * Turbulence + DirTocenter * (1 - Turbulence)).normalized;

            children.GetComponent<Rigidbody>().velocity = direction;
        }

        //重すぎる

        foreach (var children_a in prefabsFish)
        {
            foreach (var children_b in prefabsFish)
            {
                if (children_a == children_b)
                {
                    continue;
                }
                Vector3 diff = children_a.transform.position - children_b.transform.position;

                //ピタゴラス
                if (diff.magnitude < Random.Range(2, Distance))
                {
                    children_a.GetComponent<Rigidbody>().velocity = diff.normalized * children_a.GetComponent<Rigidbody>().velocity.magnitude;

                }
            }
        }


    }

}
