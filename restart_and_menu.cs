using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart_and_menu : MonoBehaviour
{

    public void restart_button()
    {
        SceneManager.LoadScene(1);
    }

    public void menu_button()
    {
        SceneManager.LoadScene(0);
    }
}
