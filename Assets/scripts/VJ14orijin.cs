using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VJ14orijin : MonoBehaviour
{
    public float _degree;
    public float _Scale;
   public int  _number;
    public float _angle;
    public int _numberStart;
    public int _StepSize;


    private float _cyrrentScale;
    private TrailRenderer _trailLenderer;
    //private Material _trailMat;
    //public Color _trailColore;


    private Vector2 _phyllotaxisPosition;


    private Vector2 calculatePhyllotaxis(float degree,float scale,int number,float angle)
    {
        ///angle = n * 137.5(角度値)
        ///radius = c*sqrt (number)

        angle = number * (degree * Mathf.Deg2Rad);

        float r = scale * Mathf.Sqrt(number);

        float x = r * Mathf.Cos(angle);
        float y = r * Mathf.Sin(angle);

        Vector2 vec2 = new Vector2(x, y);
        return vec2;

    }


    // Start is called before the first frame update
    void Start()
    {
        _cyrrentScale = _Scale;

        _trailLenderer = GetComponent<TrailRenderer>();
        //_trailMat = new Material(_trailLenderer.material);
        //_trailLenderer.material = _trailMat;

        _number = _numberStart;

        transform.localPosition = calculatePhyllotaxis(_degree, _Scale, _number,_angle);

    }

    // Update is called once per frame
    void Update()
    {
      

            _phyllotaxisPosition = calculatePhyllotaxis(_degree, _Scale, _number,_angle);
            transform.localPosition = new Vector3(_phyllotaxisPosition.x, _phyllotaxisPosition.y, 0);
        _number += _StepSize;

        Debug.Log(_angle);



    }
}
