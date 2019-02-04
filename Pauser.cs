using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pauser : MonoBehaviour
{
    public Text pauseText;
    private bool paused = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            paused = !paused;
        }

        if (paused)
        {
            Time.timeScale = 0;
            pauseText.text = "Paused";
        }
        else
        {
            Time.timeScale = 1;
            pauseText.text = "";
        }

     }
}
