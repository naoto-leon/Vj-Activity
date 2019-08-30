using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vj14 : MonoBehaviour
{
    //Audio System

    public AudioPeer _audioPeer;
    private Material _trailMat;
    public Color _trailColore;

    //public GameObject _dot;
    //プレハブ　
    public float _degree;
    public float _Scale;

    public int _numberStart;
    public int _StepSize;
    public int _maxIteretion;


    //lerping
    public bool _uselerping;
    public float _intervallerp;
    private bool _isLerping;
    private Vector3 _startPosition;
    private Vector3 _endPosition;
    private float _lerpPosTimer;
    private float _lerpPosSpeed;
    public Vector2 _lerpPosSpeedMinMax;
    public AnimationCurve _lerpPosAnimeCurve;
    public int _lerpPosBand;



    private int _number;

    private int _currentiteration;



    private TrailRenderer _trailLenderer;


    private Vector2 CalculatePhyllotaxis(float degree, float scale, int number)
    {
        //三角関数公式　

        //numver = vec1 大きさ設定　

        float angle = number * (degree * Mathf.Deg2Rad);
        //number = n degree = 角度値　
        //angle(角度)

        float r = scale * Mathf.Sqrt(number);
        // 平方根　　scale ＝ c　
        //radius

        //float x = r * (float)System.Math.Cos(angle);
        float x = r * Mathf.Cos(angle);
        //X =radius * cos(angle)
        //float y = r * (float)System.Math.Sin(angle);
        float y = r * Mathf.Sin(angle);
        //Y =radius * sin(angle)

        Vector2 vec2 = new Vector2(x, y);

        return vec2;
    }

    private Vector2 _phyllotaxisPosition;
    private bool _forward;
    public bool _repeat;
    public bool _invert;


    //scaling

    public bool _useScaleAnimataion;
    public bool _useScaleCurve;
    public Vector2 _scaleAnimMinMax;
    public AnimationCurve _scaleAnimCurve;
    public float _scaleAnimeSpeed;
    public int _scaleBand;
    private float _scaleTimer, _currentScale;

    private void SetlerpPosition()
    {

        _phyllotaxisPosition = CalculatePhyllotaxis(_degree, _Scale, _number);
        _startPosition = this.transform.localPosition;
        _endPosition = new Vector3(_phyllotaxisPosition.x, _phyllotaxisPosition.y, 0);


    }




    // Start is called before the first frame update
    void Awake()
    {
        _currentScale = _Scale;

        //_forward = true;

        _trailLenderer = GetComponent<TrailRenderer>();

        _trailMat = new Material(_trailLenderer.material);
        _trailMat.SetColor("_TintColor", _trailColore);
        _trailLenderer.material = _trailMat;


        _number = _numberStart;
        transform.localPosition = CalculatePhyllotaxis(_degree, _Scale, _number);

        //if (_uselerping)
        //{
        //    _isLerping = true;
        //    SetlerpPosition();
        //}

    }


    private void Update()
    {
        //if (_useScaleAnimataion)
        //{
            //if (_useScaleCurve)
            //{
                _scaleTimer += _scaleAnimeSpeed * Time.deltaTime;

                if (_scaleTimer >= 1)
                {
                    _scaleTimer -= 1;
                }
                _currentScale = Mathf.Lerp(_scaleAnimMinMax.x, _scaleAnimMinMax.y, _scaleAnimCurve.Evaluate(_scaleTimer));
                //Evaluate 時間指定でのアニメーションカーブ可能　
                //Lerp 第三因子によって、1と２の保管　

            //}

            //else
            //{
                //_currentScale = Mathf.Lerp(_scaleAnimMinMax.x, _scaleAnimMinMax.y, _audioPeer._audioBand[_scaleBand]);
            //}
        //}




        //if (_uselerping==true)
        //{
        //    if (_isLerping==true)
        //    {

        //        _lerpPosSpeed = Mathf.Lerp(_lerpPosSpeedMinMax.x, _lerpPosSpeedMinMax.y, _lerpPosAnimeCurve.Evaluate(_audioPeer._audioBand[_lerpPosBand]));
        //        _lerpPosTimer += Time.deltaTime * _lerpPosSpeed;
        //        transform.localPosition = Vector3.Lerp(_startPosition, _endPosition, Mathf.Clamp01(_lerpPosTimer));

        //        if (_lerpPosTimer >= 1)
        //        {
        //            _lerpPosTimer -= 1;
        //            if (_forward)
        //            {
        //                _number += _StepSize;
        //                _currentiteration++;
        //            }
        //            else
        //            {
        //                _number -= _StepSize;
        //                _currentiteration--;
        //            }
        //            if ((_currentiteration > 0) && (_currentiteration < _maxIteretion))
        //            {
        //                SetlerpPosition();
        //            }
        //            else
        //            {
        //                if (_repeat)
        //                {
        //                    if (_invert)
        //                    {
        //                        _forward = !_forward;
        //                        SetlerpPosition();
        //                    }
        //                    else
        //                    {
        //                        _number = _numberStart;
        //                        _currentiteration = 0;
        //                        SetlerpPosition();
        //                    }
        //                }
        //                else
        //                {
        //                    _isLerping = false;
        //                }
        //            }
        //        }

        //    }
        //}
        //if (_uselerping == false)
        //{
        //_phyllotaxisPosition = CalculatePhyllotaxis(_degree, _Scale, _number);
        //    transform.localPosition = new Vector3(_phyllotaxisPosition.x, _phyllotaxisPosition.y, 0);
        //    _number += _StepSize;
        //_currentiteration++;

        //}

    }
}

