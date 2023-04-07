using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sob_button_play : MonoBehaviour
{
    public void select_play()
    {       
        SceneManager.LoadScene(1);  
    }

    public void select_exit()
    {
        Application.Quit();
    }

}
