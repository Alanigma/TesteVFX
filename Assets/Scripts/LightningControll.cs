using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningControll : VFXControll
{
    [SerializeField] GameObject desactivate;
    
    override protected void Start()
    {
        base.Start();
        desactivate.SetActive(true);
    }

    protected override IEnumerator StopLater()
    {
        yield return new WaitForSeconds(duration);
        desactivate.SetActive(false);
    }
}
