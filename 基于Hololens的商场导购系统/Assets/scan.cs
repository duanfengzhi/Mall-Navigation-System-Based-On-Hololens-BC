using HoloToolkit.Unity.InputModule;
using UnityEngine;


public class scan : MonoBehaviour,IInputClickHandler {
    public bool start;
    public GameObject qrcode;
    public GameObject text;
	// Use this for initialization
	void Start () {
        start = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (start)
        {
            BeginQRcode();
        }
        else
        {
            EndQRcode();
        }
    }

    public void BeginQRcode()
    {
        qrcode.GetComponent<QRcode>().enabled = true;
       
        text.GetComponent<TextMesh>().text = "停止扫描";
        Debug.Log("开始扫描");
        start = false;
    }
    public void EndQRcode()
    {
        qrcode.GetComponent<QRcode>().enabled = false;
        
        text.GetComponent<TextMesh>().text = "开始扫描";
        start = true ;
        Debug.Log("扫描结束");
    }
}
