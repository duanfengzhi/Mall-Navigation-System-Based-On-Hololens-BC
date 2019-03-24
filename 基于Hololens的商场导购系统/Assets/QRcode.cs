using UnityEngine;
using System.Collections;
using ZXing;
using UnityEngine.UI;
using System;


public static class isActive
{
    public static bool active;

}
public static class myindex
{
    public static string index; //二维码扫出来的的商品Id；

}
public class QRcode : MonoBehaviour
{
    /// <summary> 包含RGBA </summary>
    public Color32[] data;
    /// <summary> 判断是否可以开始扫描 </summary>
    private bool isScan;
    /// <summary> canvas上的RawImage，显示相机捕捉到的图像 </summary>
    public RawImage cameraTexture;
    /// <summary> canvas上的Text，显示获取的二维码内部信息 </summary>
    public Text QRcodeText;
    /// <summary> 相机捕捉到的图像 </summary>
    private WebCamTexture webCameraTexture;
    /// <summary> ZXing中的方法，可读取二维码中的内容 </summary>
    private BarcodeReader barcodeReader;
    /// <summary> 计时，0.5s扫描一次 </summary>
    private float timer = 0;

    public GameObject Qrcode;
    //public Canvas canvas;
    public GameObject obj3;

    public GameObject GoodsInfo;

    IEnumerator Start()
    {
        barcodeReader = new BarcodeReader();

        isActive.active = false;

        // canvas.gameObject.SetActive(false);
        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);//请求授权使用摄像头
        if (Application.HasUserAuthorization(UserAuthorization.WebCam))
        {
            WebCamDevice[] devices = WebCamTexture.devices;//获取摄像头设备
            string devicename = devices[0].name;
            webCameraTexture = new WebCamTexture(devicename, 1800, 1000);//获取摄像头捕捉到的画面
            cameraTexture.texture = webCameraTexture;
            webCameraTexture.Play();
            isScan = true;
        }

    }

    /// <summary>
    /// 循环扫描，0.5秒扫描一次
    /// </summary>
    void Update()
    {

        if (isScan)
        {
            timer += Time.deltaTime;

            if (timer > 0.5f) //0.5秒扫描一次
            {
                StartCoroutine(ScanQRcode());//扫描
                timer = 0;
            }
        }
    }

    IEnumerator ScanQRcode()
    {
        data = webCameraTexture.GetPixels32();//相机捕捉到的纹理
        DecodeQR(webCameraTexture.width, webCameraTexture.height);
        yield return 0;
    }

    /// <summary>
    /// 识别二维码并显示其中包含的文字、URL等信息
    /// </summary>
    /// <param name="width">相机捕捉到的纹理的宽度</param>
    /// <param name="height">相机捕捉到的纹理的高度</param>
    private void DecodeQR(int width, int height)
    {
        var br = barcodeReader.Decode(data, width, height);
        if (br != null)
        {
            Debug.Log(br.Text);
            Qrcode.SendMessage("EndQRcode");

            isActive.active = true;

            myindex.index = br.ToString();
            GoodsInfo.SendMessage("show");
            Debug.Log("----------" + isActive.active);

        }

    }

   
}
