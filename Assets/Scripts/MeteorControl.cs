using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class MeteorControl : MonoBehaviour
{
    [SerializeField] float duration;
    VisualEffect vfx;
    
    void Start()
    {
        vfx = GetComponent<VisualEffect>();
        StartCoroutine(Stop());
    }

    
    IEnumerator Stop()
    {
        yield return new WaitForSeconds(duration);
        vfx.Stop();
    }
}
