using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vj1 : MonoBehaviour
{
    public float timer;

    public ParticleSystem items;
    ParticleSystem.Particle[] items_Particles;

    public GameObject[] FireWalks;

    
    [Range(0.0f, .5f)]
    public float beat;


    ParticleSystem.MainModule mainEmo;
    ParticleSystem.MinMaxGradient colorr = new ParticleSystem.MinMaxGradient();

    // Start is called before the first frame update
    void Start()
    {
        //Start()の中でコールバック関数の設定を行う
        //nanoKontrol2 = GameObject.Find("NanoKontrol2").GetComponent<NanoKontrol2>();
        //nanoKontrol2.valueChangedFunctions.Add(nanoKontrol2_valueChanged);
        //nanoKontrol2.keyPushedFunctions.Add(nanoKontrol2_keyPushed);

        //beat = nanoKontrol2.Slider1 + 60f / 150f;

        beat = 0.044f;
        mainEmo = items.main;


    }

    // Update is called once per frame
    void Update()
    {
        var parent = this.transform;

        if (timer > beat)
        {
            GameObject firewalk = (GameObject)Instantiate(FireWalks[Random.Range(0, 5)], new Vector3(Random.Range(-20, 20), Random.Range(-20, 20), Random.Range(-20, 20)), Quaternion.identity,parent);

            Destroy(firewalk, 3f);
            //firewalk.transform.localPosition = Vector3.zero;


            timer -= beat;
        }

        timer += Time.deltaTime;



    }
}
