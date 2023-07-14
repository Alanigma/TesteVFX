using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class IceControll : VFXControll
{
    [SerializeField] GameObject desactivate;
    [SerializeField] ParticleSystem wind;
    [SerializeField] ParticleSystem wind2;
    [SerializeField] GameObject target;
    [SerializeField] float size;

    override protected void Start()
    {
        base.Start();
        if(target != null) size = target.GetComponent<Collider>().bounds.size.y * 0.75f;
        vfx = GetComponent<VisualEffect>();
        vfx.SetFloat("AreaSize", size);
        vfx.SetFloat("SnowSize", size * 2);
        vfx.SetFloat("IceSize", size * .3f);
        
    }

    protected override IEnumerator StopLater()
    {
        yield return new WaitForSeconds(duration);
        wind.Stop();
        //wind2.Stop();
    }
}
