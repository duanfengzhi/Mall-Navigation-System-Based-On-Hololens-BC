using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using HoloToolkit.Unity.InputModule;

public class GoodsInfo : MonoBehaviour
{

    public Image[] img;
    public Text[] tex;
    public Button[] bt;
    public GameObject obj3;
    public bool active;

    //public int sum=0;
    public float showTime = 0;

    public void Start()
    {


    }

    public void Update()
    {

    }


    public void show()
    {
         string num = myindex.index;  //通过二维码解析出来的商品Id
       // string num = "12";
        string str = "Images/" + num;
        string str2 = "Info/" + num;
        string[] s = null;
        string ss = "";

        GameObject prefabInstance = Instantiate(obj3);
        prefabInstance.transform.SetParent(GameObject.Find("Canvas").gameObject.transform);
        img = prefabInstance.GetComponentsInChildren<Image>();
        tex = prefabInstance.GetComponentsInChildren<Text>();
        bt = prefabInstance.GetComponentsInChildren<Button>();
        prefabInstance.name = num;
        prefabInstance.transform.localPosition = new Vector3(0, 0, 0);

       bt[0].onClick.AddListener(delegate ()   //添加到购物车
        {
            int index = Convert.ToInt32(num);
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

       /* bt[1].onClick.AddListener(delegate ()   //关闭窗口
        {
            isActive.active = false;
            prefabInstance.transform.SetParent(null);

        });*/




        img[0].sprite = Resources.Load(str, typeof(Sprite)) as Sprite;
        ss = ((TextAsset)Resources.Load(str2)).text;
        s = ss.Split(new string[] { "\r\n" }, StringSplitOptions.None);  //按照分行符切割字符串
        tex[0].text = s[0]; //商品名称
        tex[1].text = s[1]; //商品价格
        tex[2].text = s[2]; //详细信息
        tex[3].text = s[3]; //相似商品
        tex[4].text = s[4]; //相关评论
    }

    public void destroy()
    {
        GameObject prefabInstance = GameObject.Find(myindex.index);
        prefabInstance.transform.SetParent(null);
    }

}



