using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public  static class common
{
   public static List<int> list =  new List<int>(); 
    public static void Set(int i)
    {
       
        list.Add(i);

    }

}

public static class common2
{
    public static string index; //开始导航的商品Id；

}
public class UI4 : MonoBehaviour
{
    public Image[] img;
    public Text[] tex;
    public Button[] bt;
    public GameObject obj;
   

    public void Start()
    {
           
        GameObject sv = GameObject.FindWithTag("sv");
        if (sv != null)
            for (int i = 0; i < common.list.Count; i++)
            {
                string num = Convert.ToString(common.list[i]);
                string str = "Images/" + num;
                string str2 = "Info/"+num ;
                string[] s = null;
                string ss = "";

                GameObject prefabInstance = Instantiate(obj);
                prefabInstance.transform.SetParent(GameObject.Find("Content4").gameObject.transform);
                img = prefabInstance.GetComponentsInChildren<Image>();
                tex = prefabInstance.GetComponentsInChildren<Text>();
                bt = prefabInstance.GetComponentsInChildren<Button>();
                prefabInstance.name = num;
                bt[1].onClick.AddListener(delegate ()       //删除购物车中的商品
                {
                    int n = Convert.ToInt32(prefabInstance.name);
                    prefabInstance.transform.SetParent(null);
                    common.list.Remove(n);
                });

                bt[2].onClick.AddListener(delegate ()       //开始导航
                {
                    common2.index = num;
                    SceneManager.LoadScene("scene1");
                });

                img[1].sprite = Resources.Load(str, typeof(Sprite)) as Sprite;

                   // s = File.ReadAllLines(str2);
                ss= ((TextAsset)Resources.Load(str2)).text;
                s = ss.Split('￥');
                tex[0].text = s[0];
                tex[1].text = "￥"+s[1];
                
                
            }

    }




}



