using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MyFlash : MonoBehaviour {
    public float initialFlash;
    public float endValue, duration;
    Sequence f;
    private Image flash;
    private void Start()
    {
        f = DOTween.Sequence();
        flash = GetComponent<Image>();
    }

    public void DoFlash(float value)
    {
        f.Append(flash.DOFade(initialFlash + value * endValue, duration).SetLoops(2, LoopType.Yoyo));
        f.Play();
    }

}
