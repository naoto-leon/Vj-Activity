using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChengeSceane_1 : MonoBehaviour
{
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;
    public GameObject s5;
    public GameObject s6;
    public GameObject s7;

    [SerializeField]
    public bool S1;
    [SerializeField]
    public bool S2;
    [SerializeField]
    public bool S3;
    [SerializeField]
    public bool S4;
    [SerializeField]
    public bool S5;
    [SerializeField]
    public bool S6;
    [SerializeField]
    public bool S7;


    // Start is called before the first frame update
    void Start()
    {

        //S1 = false;
        //S2 = false;
        //S3 = false;
        //S4 = false;
        //S5 = false;
        //S6 = false;
        //S7 = false;
    }

    // Update is called once per frame
    void Update()
    {


         if (S2 == true)
        {
            s1.SetActive(false);
            s2.SetActive(true);
            s3.SetActive(false);
            s4.SetActive(false);
            s5.SetActive(false);
            s6.SetActive(false);
            s7.SetActive(false);
            S1 = false;
            S3 = false;
            S4 = false;
            S5 = false;
            S6 = false;
            S7 = false;
        }
    }
}