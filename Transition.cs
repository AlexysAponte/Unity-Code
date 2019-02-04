using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    [SerializeField] private string newLevel;

    private void FixedUpdate()
    {
        StartCoroutine(LevelSwitch()); 
    }

    public IEnumerator LevelSwitch ()
    {
        if (GameObject.FindGameObjectsWithTag("Pick up").Length <= 0)
        {
            yield return new WaitForSeconds(4f);
            SceneManager.LoadScene(newLevel);
        }
    }
}
