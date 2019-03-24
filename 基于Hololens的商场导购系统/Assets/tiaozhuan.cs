using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class tiaozhuan : MonoBehaviour{
    public void UI1_2()
    {
        SceneManager.LoadScene("UI2");
    }

    public void UI2_1()
    {
        SceneManager.LoadScene("UI1");
    }

    public void UI2_3()
    {
        SceneManager.LoadScene("UI3");
    }

    public void UI2_4()
    {
        SceneManager.LoadScene("UI4");
    }

    public void UI3_2()
    {
        SceneManager.LoadScene("UI2");
    }
    public void UI4_2()
    {
        SceneManager.LoadScene("UI2");
    }

    public void UI1_5()
    {
        SceneManager.LoadScene("UI5");
    }
    public void UI5_1()
    {
        SceneManager.LoadScene("UI1");
    }
}
