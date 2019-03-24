using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Search : MonoBehaviour {
    public string s;
    public GameObject inputfile;
    public List<int> list;
    public GameObject obj3;
    public Image[] img;
    public Text[] tex;
    public Button[] bt;

    public void Start()
    {
        s = null;
        inputfile = null;
      
    }
    public void f()
    {
     
        list = new List<int>();
        inputfile = GameObject.FindWithTag("IF");
        s = inputfile.GetComponentsInChildren<Text>()[1].text;
        

         for (int i = 1; i <= 12; i++)
          {

              string num = Convert.ToString(i);
              GameObject pre = GameObject.Find(num);
            DestroyObject(pre);// 将原来的对象全部删除


            string str2 = "Info/" + num;
              string ss= ((TextAsset)Resources.Load(str2)).text;

              int a = ss.IndexOf(s);

              if (a>=0)
              {
                  list.Add(i);
              
              }

          }


          for (int i = 0; i < list.Count; i++)
          {
           
            string num = Convert.ToString(list[i]);
            string str = "Images/" + num;
            string str2 = "Info/" + num;
            string[] s = null;
            string ss = "";

            GameObject prefabInstance = Instantiate(obj3);
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

            // s = File.ReadAllLines(str2);
            ss = ((TextAsset)Resources.Load(str2)).text;
            s = ss.Split('￥');
            tex[0].text = s[0];
            tex[1].text = "￥" + s[1];


          }

    }
}
