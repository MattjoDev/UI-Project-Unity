using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class GenericButton : MonoBehaviour
{
    public Action onClick;
    public bool animate = true;

    public virtual void OnClick()
    {
        onClick?.Invoke();

        if (animate) Animate();
    }

    public void Animate() => transform.DOPunchScale(-Vector3.one * 0.2f, 0.1f); 
}
