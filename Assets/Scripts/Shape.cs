using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public Color color = Color.red;
    // Polymorphism!
    // - Abstract/Virtual - Mark a Function as 'Able to be Overriden'
    // - Override - Used to override virtual function
    protected abstract void OnDrawGizmos();
    protected virtual void PrintName()
    {
        Debug.Log("Shape!");
    }
}
