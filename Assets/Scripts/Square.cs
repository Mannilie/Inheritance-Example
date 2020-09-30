using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    public Vector3 size = Vector3.one;
    protected override void OnDrawGizmos()
    {
        Gizmos.color = color;
        Gizmos.DrawWireCube(transform.position, size);
    }
    protected override void PrintName()
    {
        Debug.Log("Square");
    }
}
