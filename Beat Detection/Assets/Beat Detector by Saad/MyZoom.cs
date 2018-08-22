using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MyZoom : MonoBehaviour {
    public float initialSize;
    public float endValue, duration;
    Sequence z;
    private void Start()
    {
        z = DOTween.Sequence();
    }
    public void DoZoom(float value)
    {
        z.Append(Camera.main.DOOrthoSize(initialSize + value * endValue, duration).SetLoops(2, LoopType.Yoyo));
        z.Play();
    }
}
