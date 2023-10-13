using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    Color c;
    private void Start()
    {
        c = GetComponent<Renderer>().material.color;
    }
    public void HoverOver()
    {
        Debug.Log("Hover");
    }

    public void HoverExited()
    {
        Debug.Log("Hover exited");
    }

    public void Activated()
    {
        Debug.Log("activated");
        GetComponent<Renderer>().material.color = Color.green;
    }
    public void Deactivated()
    {
        GetComponent<Renderer>().material.color = c;
    }
    public void Selected()
    {
        Debug.Log("selected");
        GetComponent<Renderer>().material.color = Color.yellow;
    }
    public void SelectExited()
    {
        GetComponent<Renderer>().material.color = c;
    }

  
}
