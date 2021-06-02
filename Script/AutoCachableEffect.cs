using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]


public class AutoCachableEffect : MonoBehaviour
{
    public string FilePath
    {
        get;
        set;
    }


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
                SystemManager.Instance.EffectManager.RemoveEffect(this);
                break;
            }
        }
    }
}
