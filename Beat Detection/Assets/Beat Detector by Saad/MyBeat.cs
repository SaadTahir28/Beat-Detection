using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MyBeat : MonoBehaviour
{
    public float initialScale;//since we need to retain our scale if no beat detected
    public float endValue, duration;
    Sequence s;
    private void Start()
    {
        s = DOTween.Sequence();
    }
    public void DoBeat(float value)
    {
        s.Append(transform.DOScale(initialScale + value * endValue, duration).SetLoops(2, LoopType.Yoyo));
        s.Play();
    }




}
