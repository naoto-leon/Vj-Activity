using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalScroll : MonoBehaviour
{
    

    [SerializeField]
    Shader m_sheder;

    [SerializeField]
    [Range(0f, .49f)]
    float speed ;

    [SerializeField]
    bool speedMove;

    public float m_speed 
    {
        get { return this.speed; }
        private set { this.speed = value; }
    }

    Material m_mat;


    private void Start()
    {
        speedMove = false;

        
    }

    private void Update()
    {
        if (speedMove == true)
        {
            speed =0.001f;
            //speed = speed+speed*0.001f;
            
        }
    }


    //↓プロパティでもgetcompoでもとれない。。。
    public void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        if (m_mat == null)
        {
            m_mat = new Material(m_sheder);
            // Materialが再生が終了したら破棄されるようにHideFlagsを設定する
            m_mat.hideFlags = HideFlags.DontSave;
        }


        m_mat.SetFloat("_ScrollValue", (float)Time.frameCount * m_speed);

        //↓rendertexture 更新かな
        Graphics.Blit(src, dest, m_mat);

    }

}
