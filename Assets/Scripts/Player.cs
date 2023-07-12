using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Player : MonoBehaviour
{
    Animator anim;
    [SerializeField] GameObject LightAtack;
    [SerializeField] GameObject MeteorAtack;
    [SerializeField] GameObject IceAtack;

    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(AutomaticAnim());
    }

    IEnumerator AutomaticAnim()
    {
        yield return new WaitForSeconds(3);
        anim.Play("Mage-Skill3");
        yield return new WaitForSeconds(0.5f);
        Lightning();
        yield return new WaitForSeconds(3);
        anim.Play("Mage-Skill1");
        Ice();
        yield return new WaitForSeconds(3);
        anim.Play("Mage-Skill2");
        Meteor();
    }

    void Lightning()
    {
        Instantiate(LightAtack, new Vector3(transform.position.x, transform.position.y + 5, transform.position.z + 5), Quaternion.identity);
    }

    void Ice()
    {
        Instantiate(IceAtack, new Vector3(transform.position.x, transform.position.y, transform.position.z + 5), Quaternion.identity);
    }

    void Meteor()
    {
        Instantiate(MeteorAtack, new Vector3(transform.position.x, transform.position.y + 6, transform.position.z), Quaternion.identity);
    }
}
