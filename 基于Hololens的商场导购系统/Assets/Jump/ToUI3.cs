using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.SceneManagement;

public class ToUI3 : MonoBehaviour, IInputClickHandler
{

    private Vector3 origScale;


    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        SceneManager.LoadScene("UI3");
        Debug.Log("efw");
    }


}
