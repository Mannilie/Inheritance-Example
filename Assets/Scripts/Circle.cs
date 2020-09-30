using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    public float radius = .5f;
    protected override void OnDrawGizmos()
    {
        Gizmos.color = color;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    protected override void PrintName()
    {
        Debug.Log("Circle");
    }
}
