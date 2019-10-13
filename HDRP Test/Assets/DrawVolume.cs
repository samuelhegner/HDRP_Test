using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawVolume : MonoBehaviour
{
    public Collider col;
    private void Start()
    {
    }

    private void OnDrawGizmos()
    {
        if(col.GetType() == typeof(SphereCollider))
        {
            SphereCollider sCol = (SphereCollider)col;
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.TransformPoint(sCol.center), sCol.radius);
            Gizmos.color = new Color(1, 0, 0, 0.2f);
            Gizmos.DrawSphere(transform.TransformPoint(sCol.center), sCol.radius);
        }
        else if(col.GetType() == typeof(BoxCollider))
        {
            BoxCollider bCol = (BoxCollider)col;
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(transform.TransformPoint(bCol.center), bCol.size);
            Gizmos.color = new Color(1, 0, 0, 0.2f);
            Gizmos.DrawCube(transform.TransformPoint(bCol.center), bCol.size);
        }
        else
        {
            return;
        }
    }
}
