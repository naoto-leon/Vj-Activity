using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vj8 : MonoBehaviour
{
    public float input {get;set;}

    public GameObject[] Pa;

    ParticleSystem.MainModule mainEmo1;
    ParticleSystem.MainModule mainEmo2;
    ParticleSystem.MainModule mainEmo3;
    ParticleSystem.MainModule mainEmo4;
    ParticleSystem.MainModule mainEmo5;

    [Range(1, 8)]
    public float Emo1_Start_Size;

    [Range(8, 12)]
    public float Emo2_Start_Size;

    [Range(0, 360)]
    public byte color_one;

    [Range(0, 360)]
    public byte color_two;

    [Range(0, 360)]
    public byte color_three;

    [SerializeField]
    public bool RandomColor;



    // Start is called before the first frame update
    void Start()
    {
        RandomColor = false;

        Emo1_Start_Size = 3.1f;
        Emo2_Start_Size = 9;

        color_one = 231;
        color_two = 231;
        color_three = 231;

        Pa = new GameObject[transform.childCount];

        for (int i = 0; i < Pa.Length; i++)
        {
            Pa[0] = transform.GetChild(0).gameObject;
            Pa[1] = transform.GetChild(1).gameObject;
            Pa[2] = transform.GetChild(2).gameObject;
            Pa[3] = transform.GetChild(3).gameObject;
            Pa[4] = transform.GetChild(4).gameObject;

            var _Emo1 = Pa[0].GetComponent(typeof(ParticleSystem)) as ParticleSystem;
            var _Emo2 = Pa[1].GetComponent(typeof(ParticleSystem)) as ParticleSystem;
            var _Emo3 = Pa[2].GetComponent(typeof(ParticleSystem)) as ParticleSystem;
            var _Emo4 = Pa[3].GetComponent(typeof(ParticleSystem)) as ParticleSystem;
            var _Emo5 = Pa[4].GetComponent(typeof(ParticleSystem)) as ParticleSystem;

            mainEmo1 = _Emo1.main;
            mainEmo2 = _Emo2.main;
            mainEmo3 = _Emo3.main;
            mainEmo4 = _Emo4.main;
            mainEmo5 = _Emo5.main;

        }


        }

    // Update is called once per frame
    void Update()
    {
        mainEmo1.startSize = (input*3) + Emo1_Start_Size;
        mainEmo2.startSize = (input*3) + Emo1_Start_Size;
        mainEmo3.startSize = (input * 4) + Emo2_Start_Size;
        mainEmo4.startSize = (input * 4) + Emo2_Start_Size;

        mainEmo1.startColor = ColorHSV.FromHsv(color_one,200,255);
        mainEmo2.startColor = ColorHSV.FromHsv(color_one, 200, 255);
        mainEmo3.startColor = ColorHSV.FromHsv(color_two, 200, 255);
        mainEmo4.startColor = ColorHSV.FromHsv(color_two, 200, 255);
        mainEmo5.startColor = ColorHSV.FromHsv(color_three, 200, 255);

        if (RandomColor == true)
        {
            mainEmo1.startColor = ColorHSV.FromHsv(Random.Range(0, 360), 200, 255);
            mainEmo2.startColor = ColorHSV.FromHsv(Random.Range(0, 360), 200, 255);
            mainEmo3.startColor = ColorHSV.FromHsv(Random.Range(0, 360), 200, 255);
            mainEmo4.startColor = ColorHSV.FromHsv(Random.Range(0, 360), 200, 255);
            mainEmo5.startColor = ColorHSV.FromHsv(Random.Range(0, 360), 200, 255);

        }
    }
}
