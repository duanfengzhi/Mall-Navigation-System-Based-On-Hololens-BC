using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.WSA.Input;

public class Clicked : MonoBehaviour
{
    public Vector3 v;
    public bool start = true;

    void OnSelect()
    {
        if (start)
        {
            v = GameObject.Find("Main Camera").transform.position;
            GameObject.Find("Text").GetComponent<TextMesh>().text = "end";
        }
        else
        {
            GameObject.Find("Text").GetComponent<TextMesh>().text = "start";
            GameObject.Find("Main Camera").SendMessage("Find");
        }

        start = !start;
    }
}
