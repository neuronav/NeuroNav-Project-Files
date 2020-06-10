using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelect : MonoBehaviour
{
    public void ChangeMenuScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
