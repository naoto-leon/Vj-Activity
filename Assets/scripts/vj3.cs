using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vj3 : MonoBehaviour
{
    //nanoKontrol2を宣言
    private NanoKontrol2 nanoKontrol2;

    public float input { get; set; }

    public float timer;
    public float timer_4;
    public float timer_5;

    public GameObject[] Pa;


    [Range(0.0f, 0.1f)]
    public float beat_3;
    [Range(0.0f, 0.1f)]
    public float beat_4;
    [Range(0.0f, 0.1f)]
    public float beat_5;



    [Range(100f, 1000f)]
    public float Emo1_Emission;

    [Range(0, .8f)]
    public float Emo3_StartLifeTime_max;
    [Range(3f, 9f)]
    public float Emo3_StartSize_max;
    [Range(3.62f, 9f)]
    public float Emo4_StartSize_max;
    [Range(4.73f, 10f)]
    public float Emo5_StartSize_max;

    [Range(.1f, 2f)]
    public float Emo6_Simulation_Speed;

    [Range(.1f, 2f)]
    public float Emo7_Simulation_Speed; 

    public bool StopEmotion;

    [Range(1f,5f)]
    public float Emo8_Start_Lifetime;

    [Range(1f, 100f)]
    public float Emo8_Start_Speed;

    ParticleSystem.EmissionModule mainEmo;
    ParticleSystem.MainModule mainEmo3;
    ParticleSystem.MainModule mainEmo4;
    ParticleSystem.MainModule mainEmo5;
    ParticleSystem.MainModule mainEmo6;
    ParticleSystem.MainModule mainEmo7;
    ParticleSystem.MainModule mainEmo8;

    // Start is called before the first frame update
    void Start()
    {
        //Start()の中でコールバック関数の設定を行う

        //nanoKontrol2 = GameObject.Find("NanoKontrol2").GetComponent<NanoKontrol2>();
        //nanoKontrol2.valueChangedFunctions.Add(nanoKontrol2_valueChanged);
        //nanoKontrol2.keyPushedFunctions.Add(nanoKontrol2_keyPushed);


        beat_3 = 0.03f;
        beat_4 = 0.074f;
        beat_5 = 0.0571f;

     
        Emo1_Emission = 100f;
        Emo3_StartLifeTime_max = .3f;
        Emo3_StartSize_max = 7.98f;
        Emo4_StartSize_max = 6.11f;
        Emo5_StartSize_max = 4.73f;
        Emo6_Simulation_Speed = 2f;
        Emo7_Simulation_Speed = 2f;
        Emo8_Start_Lifetime = 1;
        Emo8_Start_Speed = 100;

        StopEmotion = false;

        Pa = new GameObject[transform.childCount];

        for (int i = 0; i < Pa.Length; i++)
        {
            Pa[0] = transform.GetChild(0).gameObject;
            Pa[2] = transform.GetChild(2).gameObject;
            Pa[3] = transform.GetChild(3).gameObject;
            Pa[4] = transform.GetChild(4).gameObject;
            Pa[5] = transform.GetChild(5).gameObject;
            Pa[6] = transform.GetChild(6).gameObject;
            Pa[7] = transform.GetChild(7).gameObject;

            var Emo = Pa[0].GetComponent(typeof(ParticleSystem)) as ParticleSystem;
            var _Emo3 = Pa[2].GetComponent(typeof(ParticleSystem)) as ParticleSystem;
            var _Emo4 = Pa[3].GetComponent(typeof(ParticleSystem)) as ParticleSystem;
            var _Emo5 = Pa[4].GetComponent(typeof(ParticleSystem)) as ParticleSystem;
            var _Emo6 = Pa[5].GetComponent(typeof(ParticleSystem)) as ParticleSystem;
            var _Emo7 = Pa[6].GetComponent(typeof(ParticleSystem)) as ParticleSystem;
            var _Emo8 = Pa[7].GetComponent(typeof(ParticleSystem)) as ParticleSystem; 

            mainEmo = Emo.emission;
            mainEmo3 = _Emo3.main;
            mainEmo4 = _Emo4.main;
            mainEmo5 = _Emo5.main;
            mainEmo6 = _Emo6.main;
            mainEmo7 = _Emo7.main;
            mainEmo8 = _Emo8.main; 
   


        }
      
    }

    //public void nanoKontrol2_valueChanged(string keyName, int keyValue)
    //{
    //    Debug.Log(keyName);
    //    Debug.Log(keyValue);
    //}


    //public void nanoKontrol2_keyPushed(string keyName)
    //{
    //    Debug.Log(keyName);
    //}




    // Update is called once per frame
    void FixedUpdate()
    {
        mainEmo.rateOverTime = Emo1_Emission;
        mainEmo8.startLifetime = Emo8_Start_Lifetime;
        mainEmo8.startSpeed = Emo8_Start_Speed;
        mainEmo6.simulationSpeed = Emo6_Simulation_Speed;
        mainEmo7.simulationSpeed = Emo7_Simulation_Speed;

       

        if (StopEmotion == true)
        {
            mainEmo6.simulationSpeed = .15f;
            mainEmo7.simulationSpeed = .15f;
        }

        ///
        ///Nano Controal
        ///
        //mainEmo.rateOverTime = (nanoKontrol2.Slider1 * 7) + Emo1_Emission;
        //mainEmo8.startLifetime = (nanoKontrol2.Slider2 / 12) + Emo8_Start_Lifetime;
        //mainEmo8.startSpeed = nanoKontrol2.Slider3 + Emo8_Start_Speed;






        ////
        ///can't get BPM 
        ///

        //if (timer > beat_3)
        //{
        //    timer -= beat_3;

        //    mainEmo3.startLifetime = Emo3_StartLifeTime_max;
        //    mainEmo3.startSize = Emo3_StartSize_max;
        //}
        //else
        //{
        //    mainEmo3.startLifetime = .3f;
        //    mainEmo3.startSize = 5.5f;
        //}

        //timer += Time.deltaTime;

        //if (timer_4 > beat_4)
        //{
        //    timer_4 -= beat_4;

        //    mainEmo4.startSize = Emo4_StartSize_max;
        //}
        //else
        //{
        //    mainEmo4.startSize = 3.62f;
        //}
        //timer_4 += Time.deltaTime;



        //if (timer_5 > beat_5)
        //{
        //    timer_5 -= beat_5;

        //    mainEmo5.startSize = Emo5_StartSize_max;
        //}
        //else
        //{
        //    mainEmo5.startSize = 4.73f;
        //}

        //timer_5 += Time.deltaTime;



        mainEmo3.startLifetime = input * Emo3_StartLifeTime_max;
            mainEmo3.startSize = input * Emo3_StartSize_max;
        

            mainEmo4.startSize = input * Emo4_StartSize_max;
        
     
            mainEmo5.startSize = input + Emo5_StartSize_max;
        

    }

}
