using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class Navigation : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    void Start()
    {
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();//初始化navMeshAgent
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//鼠标左键点下  
        {
            Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);//住摄像机向鼠标位置发射射线 
            RaycastHit mHit;
            if (Physics.Raycast(mRay, out mHit))//射线检验 
            {
                if (mHit.collider.gameObject.tag == "plane")
                {
                    navMeshAgent.SetDestination(mHit.point);//mHit.point就是射线和plane的相交点，实为碰撞点
                    print("坐标为: " + mHit.point.ToString() + "\n");
                }
            }
        }
    }
}
