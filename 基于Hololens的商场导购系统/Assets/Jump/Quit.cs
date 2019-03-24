using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour, IInputClickHandler
{
    //这是退出脚本
    public void OnInputClicked(InputClickedEventData eventData)
    {
        Application.Quit();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
