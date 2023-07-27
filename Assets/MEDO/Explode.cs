using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    [SerializeField]
    Rigidbody[] m_RBs;
    [SerializeField]
    float m_ExplosionForce;
    
    void Start()
    {
        foreach (Rigidbody _rb in m_RBs)
        {
            _rb.AddExplosionForce(m_ExplosionForce, transform.position, 2);
        }
    }
}
