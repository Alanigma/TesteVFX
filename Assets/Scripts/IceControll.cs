using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class IceControll : MonoBehaviour
{
    VisualEffect effect;
    [SerializeField] GameObject target;
    [SerializeField] float size;

    void Start()
    {
        if(target != null) size = target.GetComponent<Collider>().bounds.size.y * 0.75f;
        effect = GetComponent<VisualEffect>();
        effect.SetFloat("AreaSize", size);
        effect.SetFloat("SnowSize", size * 2);
        effect.SetFloat("IceSize", size * .3f);
        StartCoroutine(Stop());
    }

    IEnumerator Stop()
    {
        yield return new WaitForSeconds(4.2f);
        effect.SendEvent("Stop");
    }
}
