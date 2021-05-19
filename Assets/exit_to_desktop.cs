using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class exit_to_desktop : MonoBehaviour
{
    // quits game or exits play mode if editor is being used
    public void doExitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }

}