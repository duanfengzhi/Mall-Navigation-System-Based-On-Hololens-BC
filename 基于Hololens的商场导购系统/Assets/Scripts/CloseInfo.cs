using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
public class CloseInfo : MonoBehaviour,IInputClickHandler {
    public void OnInputClicked(InputClickedEventData eventData)
    {
        
        GameObject prefabInstance = GameObject.Find(myindex.index);
        Debug.Log(prefabInstance.name);
        prefabInstance.transform.SetParent(null);
       
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
