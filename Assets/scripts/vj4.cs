using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vj4 : MonoBehaviour
{
    private NanoKontrol2 nanoKontrol2;


    public float timer;
    public float Count;

    public ParticleSystem items;

    [Range(0.0f, .5f)]
    public float beat;

    [Range(0.05f, 1.3f)]
    public float startSize_max;

    [Range(0.0f, 0.5f)]
    public float startSize_min;

    [Range(0.0f, 5f)]
    public float simulationSpeed;

    [Range(0, 360)]
    public byte color_one;

    [Range(0, 360)]
    public byte color_two;

    [SerializeField]
    public bool stopMove;

    [SerializeField]
    public bool RandomColor;

    ParticleSystem.MainModule mainEmo;
    ParticleSystem.MinMaxGradient colorr = new ParticleSystem.MinMaxGradient();


    // Start is called before the first frame update
    void Start()
    {
        beat = 60f / 165f;

        mainEmo = items.main;
        Count = 0f;
        startSize_max = 0.5f;       

        simulationSpeed = 0f;
        stopMove = false;
        RandomColor = false;

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
        ///
        ///Nano Controal
        ///

        //startSize_max = (nanoKontrol2.Slider6 * 7) + startSize_max;
        //startSize_min = (nanoKontrol2.Slider7 * 7) + startSize_min;

        if (timer > beat)
        {
            //mainEmo.startSize =  startSize_max;
            mainEmo.startSize = (nanoKontrol2.Slider6*.002f ) + startSize_max;

            //mainEmo.simulationSpeed = simulationSpeed;
            mainEmo.simulationSpeed = (nanoKontrol2.Slider8  * .015f ) + simulationSpeed;

            timer -= beat;

        }
        else
        {
            //mainEmo.startSize = startSize_min; 
            mainEmo.startSize = (nanoKontrol2.Slider7 * .0015f ) + startSize_min;
            

        }

        timer += Time.deltaTime;

        colorr.mode = ParticleSystemGradientMode.TwoColors;
        colorr.colorMin = ColorHSV.FromHsv(color_one, 255, 255);
        colorr.colorMax = ColorHSV.FromHsv(color_two, 255, 255);

        mainEmo.startColor = colorr;

        if (stopMove == true)
        {
            simulationSpeed = 0f;
        }

        if (RandomColor == true)
        {
            colorr.colorMin = ColorHSV.FromHsv(Random.Range(0,360), 255, 255);
            colorr.colorMax = ColorHSV.FromHsv(Random.Range(0,360), 255, 255);

            mainEmo.startColor = colorr;
        }





    }
}
