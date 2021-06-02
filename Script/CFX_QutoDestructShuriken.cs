using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]

public class CFX_QutoDestructShuriken : MonoBehaviour
{
    public bool OnlyDeactivate;

    void OnEnable()
    {
        StartCoroutine("ChecklfAlive");
    }

    IEnumerator ChecklfAlive()
    {

        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            if (!GetComponent<ParticleSystem>().IsAlive(true))
            {
                if (OnlyDeactivate)
                {
                    #if UNITY_5_5
                    this.gameObject.SetActiveResoursively(false);
                    #else
                    this.gameObject.SetActive(false);
                    #endif
                }
                else
                    GameObject.Destroy(this.gameObject);
                break;
            }
        }
    }
}
