using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour
{

    [Space(10)]
    public float maximunHeight;
    public float minimunHeight;

    [Header("Safe Frame")]
    [Range(0f, 1f)]
    [SerializeField] float safeFrameTop;
    [Range(0f, 1f)]
    [SerializeField] float safeFrameBottom;
 
    void OnDrawGizmos()
    {
        DrawCameraGizmos();
    }

    void DrawCameraGizmos()
    {
        Vector3 corner1 = Camera.main.ViewportToWorldPoint(new Vector3(0f, safeFrameTop, 1f));
        Vector3 corner2 = Camera.main.ViewportToWorldPoint(new Vector3(1f, safeFrameTop, 1f));
        Vector3 corner3 = Camera.main.ViewportToWorldPoint(new Vector3(0f, safeFrameBottom, 1f));
        Vector3 corner4 = Camera.main.ViewportToWorldPoint(new Vector3(1f, safeFrameBottom, 1f));

        Gizmos.color = Color.green;

        Gizmos.DrawLine(corner1, corner2);
        Gizmos.DrawLine(corner3, corner4);
    }
}
