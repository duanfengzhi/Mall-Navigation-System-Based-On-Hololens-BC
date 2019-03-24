using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using HoloToolkit.Unity.InputModule;

public class show : MonoBehaviour
{

    public Text[] tex;
    public GameObject obj;


    public void Start()
    {

        string num = common2.index;  //通过二维码解析出来的商品Id，这里实际上是UI4传过来的

        string str2 = "Info/" + num;
        string[] s = null;
        string ss = "";

        GameObject prefabInstance = Instantiate(obj);
        prefabInstance.transform.SetParent(GameObject.Find("Canvas").gameObject.transform);

        tex = prefabInstance.GetComponentsInChildren<Text>();
        prefabInstance.name = num;
        prefabInstance.transform.localPosition = new Vector3(-367, 62,0);



        ss = ((TextAsset)Resources.Load(str2)).text;
        s = ss.Split(new string[] { "\r\n" }, StringSplitOptions.None);  //按照分行符切割字符串
        tex[0].text = "正在导航：" + s[0]; //商品名称


    }


}




