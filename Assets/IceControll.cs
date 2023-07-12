using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class IceControll : MonoBehaviour
{
    VisualEffect effect;

    void Start()
    {
        effect = GetComponent<VisualEffect>();
        StartCoroutine(Stop());
    }

    IEnumerator Stop()
    {
        yield return new WaitForSeconds(4.5f);
        effect.SendEvent("Stop");
    }
}
