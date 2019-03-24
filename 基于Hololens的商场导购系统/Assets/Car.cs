using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using HoloToolkit.Unity.InputModule;

public class Car : MonoBehaviour {

    public Image[] img;
    public Text[] tex;
    public Button[] bt;
    public GameObject obj2;


    public void Start()
    {
        for(int i =1; i <=12; i++)
        {
            string num = Convert.ToString(i);
            string str = "Images/" + num;
            string str2 = "Info/"+num;
            string[] s = null;
            string ss = "";

            GameObject prefabInstance = Instantiate(obj2);
            prefabInstance.transform.SetParent(GameObject.Find("Content").gameObject.transform);
            img = prefabInstance.GetComponentsInChildren<Image>();
            tex = prefabInstance.GetComponentsInChildren<Text>();
            bt = prefabInstance.GetComponentsInChildren<Button>();
            prefabInstance.name = num;
            

            bt[0].onClick.AddListener(delegate ()
            {
                int index = Convert.ToInt32(prefabInstance.name);
                bool t = true;
                for (int j = 0; j < common.list.Count; j++)
                {
                    if (common.list[j] == index)
                    {
                        t = false;
                        break;
                    }


                }

                if (t)
                {
                    common.list.Add(index);
                }

            });



           img[0].sprite = Resources.Load(str, typeof(Sprite)) as Sprite;
           ss = ((TextAsset)Resources.Load(str2)).text;
            s=ss.Split(new string[] { "\r\n" }, StringSplitOptions.None);  //按照分行符切割字符串
            
            tex[0].text = s[0];
            tex[1].text = s[1];
            Debug.Log("------------" +ss);
            Debug.Log("=======" + s.Length);
           /*s = ss.Split('￥');
            tex[0].text = s[0];
            tex[1].text ="￥"+ s[1];*/





        }

    }



}


