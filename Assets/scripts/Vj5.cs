using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vj5 : MonoBehaviour
{
    //nanoKontrol2を宣言
    private NanoKontrol2 nanoKontrol2;

    public float timer;
    public float Count; 

    public ParticleSystem items;

    [Range(0.0f,.5f)]
    public float beat ;

    [Range(1.0f,100.0f)]
    public float simulatespeed;

    [Range(0f, 2f)]
    public float startsize;

    [Range(0, 360)]
    public byte color_one;

    [Range(0, 360)]
    public byte color_two;

    [SerializeField]
    public bool Rgbswich;

    ParticleSystem.MainModule mainEmo;
    ParticleSystem.MinMaxGradient colorr = new ParticleSystem.MinMaxGradient();

    // Start is called before the first frame update
    void Start()
    {
        beat = 60f / 165f;

        mainEmo = items.main;
        Count = 0f;
        Rgbswich = false;
        color_one = 10;
        color_two = 255;


        nanoKontrol2 = GameObject.Find("NanoKontrol2").GetComponent<NanoKontrol2>();
        nanoKontrol2.valueChangedFunctions.Add(nanoKontrol2_valueChanged);
        nanoKontrol2.keyPushedFunctions.Add(nanoKontrol2_keyPushed);

    }







    public void nanoKontrol2_valueChanged(string keyName, int keyValue)
    {
        //Debug.Log(keyName);
        //Debug.Log(keyValue);
    }


    public void nanoKontrol2_keyPushed(string keyName)
    {
        //Debug.Log(keyName);
    }



    // Update is called once per frame
    void Update()
    {
        mainEmo.startSize = (nanoKontrol2.Slider4*0.005f)+startsize;

        if (timer>beat)
        {
            mainEmo.simulationSpeed = Random.Range(1f, (nanoKontrol2.Slider5*.5f)+simulatespeed) ;
            //mainEmo.startSize = startsize;
            timer -= beat;
            
        }

        timer += Time.deltaTime;
        Count += Time.deltaTime;


        colorr.mode = ParticleSystemGradientMode.TwoColors;
        colorr.colorMin = ColorHSV.FromHsv(color_one, 255, 255);
        colorr.colorMax = ColorHSV.FromHsv(color_two, 255, 255);

        mainEmo.startColor = colorr;


        //Debug.Log(Count);

        if (Rgbswich == true)
        {
            //color_one = (byte)(color_one + (Count*.1));
            //color_two = (byte)(color_one + (Count*100));
            colorr.colorMin = ColorHSV.FromHsv(Random.Range(0, 360), 255, 255);
            colorr.colorMax = ColorHSV.FromHsv(Random.Range(0, 360), 255, 255);

            mainEmo.startColor = colorr;
        }
 




    }

}
