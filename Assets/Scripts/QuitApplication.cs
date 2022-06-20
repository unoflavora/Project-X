using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    bool isExiting = false;

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isExiting)
        {
            isExiting = true;
            Application.Quit();
        }
    }
}
