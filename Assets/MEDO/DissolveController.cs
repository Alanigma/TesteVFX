using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveController : MonoBehaviour
{
    float m_DissolveAlpha;
    [SerializeField]
    float m_Delay;
    [SerializeField]
    float m_Speed;
    
    Material[] m_Mat;
    
    void Start()
    {
        m_Mat = GetComponent<MeshRenderer>().materials;
        StartCoroutine(nameof(Active));
    }

    public IEnumerator Active(){
        yield return new WaitForSeconds(m_Delay);
        while (m_DissolveAlpha < 1)
        {
            m_DissolveAlpha += m_Speed;
            foreach (Material _mat in m_Mat)
            {
                _mat.SetFloat("_Alpha", m_DissolveAlpha);
            }
            yield return new WaitForSeconds(0.05f);
        }
        Destroy(gameObject);
    }
}
