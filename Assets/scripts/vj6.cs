using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vj6 : MonoBehaviour
{

    public float timer;

    public ParticleSystem items;
    //ParticleSystem.Particle[] items_Particles;

    [Range(0.0f, 5f)]
    public float beat;
    [Range(-3, 3)]
    public int orbitalX;

    [Range(-3, 3)]
    public int orbitalZ;

    [Range(-3, 3)]
    public int offsetZ;

    [Range(0, 360)]
    public byte color_one;

    [Range(0, 360)]
    public byte color_two;

    [SerializeField]
    public bool RandomColor;

    ParticleSystem.MainModule mainEmo;
    ParticleSystem.VelocityOverLifetimeModule voltm;
    ParticleSystem.MinMaxGradient colorr = new ParticleSystem.MinMaxGradient();

    [SerializeField]
    public bool AutoSwitch; 

    [SerializeField]
     float Waitone;
    [SerializeField]
     float Waittwo;
    private int setNum;

    // Start is called before the first frame update
    void Start()
    {
        beat = 60f / 150f;
        mainEmo = items.main;
        voltm = items.velocityOverLifetime;

        orbitalX = 0;
        orbitalZ = 2;
        offsetZ = 0;

        color_one = 27;
        color_two = 40;

        RandomColor = false;
        AutoSwitch = false;

        //Waitone = 15f;
        //Waittwo = 15f;
        setNum = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (timer > beat)
        {
            voltm.orbitalZ = orbitalZ;
            voltm.orbitalX = orbitalX;
            voltm.orbitalOffsetZ = offsetZ;
            timer -= beat;
        }
        else
        {
            voltm.orbitalZ = 2;
            voltm.orbitalX = orbitalX;
            voltm.orbitalOffsetZ = offsetZ;
        }

        timer += Time.deltaTime;



        colorr.mode = ParticleSystemGradientMode.TwoColors;
        colorr.colorMin = ColorHSV.FromHsv(color_one, 100, 255);
        colorr.colorMax = ColorHSV.FromHsv(color_two, 100, 255);

        mainEmo.startColor = colorr;

        if (RandomColor == true)
        {
            colorr.colorMin = ColorHSV.FromHsv(Random.Range(0, 360), 200, 255);
            colorr.colorMax = ColorHSV.FromHsv(Random.Range(0, 360), 200, 255);

            mainEmo.startColor = colorr;
        }

        if (AutoSwitch == true)
        {
            AutoChenge();
        }





    }

    public void AutoChenge()
    {

        if (Waitone > 0)
        {
            Waitone -= Time.deltaTime;
        }
        else
        {
            Waitone = Waittwo;
            setNum++;

            if (setNum > 7)
            {
                setNum = 0;
            }
        }

        if (setNum == 0)
        {
            voltm.orbitalX = 0f;
            voltm.orbitalZ = 2f;
            voltm.orbitalOffsetZ = 0f;
        }
        if (setNum == 1)
        {
            voltm.orbitalX = 3f;
            voltm.orbitalZ = 2f;
            voltm.orbitalOffsetZ = 0f;
        }
        if (setNum == 2)
        {
            voltm.orbitalX = -3f;
            voltm.orbitalZ = 2f;
            voltm.orbitalOffsetZ = 0f;
        }
        if (setNum == 3)
        {
            voltm.orbitalX = -3f;
            voltm.orbitalZ = 2f;
            voltm.orbitalOffsetZ = -3f;
        }
        if (setNum == 4)
        {
            voltm.orbitalX = -3f;
            voltm.orbitalZ = 2f;
            voltm.orbitalOffsetZ = 3f;
        }
        if (setNum == 5)
        {
            voltm.orbitalX = 3f;
            voltm.orbitalZ = 2f;
            voltm.orbitalOffsetZ = 3f;
        }
        if (setNum == 6)
        {
            voltm.orbitalX = 3f;
            voltm.orbitalZ = 0f;
            voltm.orbitalOffsetZ = 3f;
        }
        if (setNum == 7)
        {
            voltm.orbitalX = -3f;
            voltm.orbitalZ = -3f;
            voltm.orbitalOffsetZ = 3f;
        }



    }
}
