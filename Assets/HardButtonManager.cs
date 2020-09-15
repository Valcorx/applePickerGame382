using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardButtonManager : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene("_Scene_2");
    }
}
