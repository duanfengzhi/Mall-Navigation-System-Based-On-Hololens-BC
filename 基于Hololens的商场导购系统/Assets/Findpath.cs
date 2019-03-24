using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.AI;

public class Findpath : MonoBehaviour
{
    private NavMeshAgent _navPlayer;
    private NavMeshPath _navPath;
    public LineRenderer lineGameObject;
    private Vector3 v;
    // Use this for initialization

    void Start()
    {
        _navPlayer = transform.GetComponent<NavMeshAgent>();
        _navPath = new NavMeshPath();
        v.Set((float)-1.67, (float)-2, (float) - 0.09);
    }    // Update is called once per frame

    void Update()
    {
        _navPlayer.SetDestination(v);
        _navPlayer.CalculatePath(v, _navPath);
        if (_navPath.corners.Length < 2)
            return;
                else
                {
                    lineGameObject.positionCount = _navPath.corners.Length;

                    Vector3[] tmpCorners = _navPath.corners;

                    for (int i = 0; i < tmpCorners.Length; i++)
                    {

                        tmpCorners[i].y -=0.2f;

                    }

                    lineGameObject.SetPositions(tmpCorners);
         
                }

            }

        }

