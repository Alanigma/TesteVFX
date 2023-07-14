using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VFXControll : MonoBehaviour
{
    [SerializeField] protected float duration;
    protected VisualEffect vfx;
    
    virtual protected void Start()
    {
        StartCoroutine(nameof(StopLater));
    }

    virtual protected IEnumerator StopLater()
    {
        yield return new WaitForSeconds(duration);
        Destroy(gameObject);
    }
}
