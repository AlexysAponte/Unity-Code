using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Disappear());
    }

    public IEnumerator Disappear()
    {
            yield return new WaitForSeconds(5f);
    }

}
