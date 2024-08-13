using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadlockColor : MonoBehaviour
{
    TimeBLink blink;
    private GameObject thisDial;
    

    [HideInInspector]
    public bool isSelected;
   
    private void Awake()
    {
        blink = FindFirstObjectByType<TimeBLink>();
        thisDial = gameObject;
        
    }

    public void BlinkMaterial()
    {
        //thisDial.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        //if (isSelected)
        //{
        //    thisDial.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.Lerp(Color.clear, Color.grey, Mathf.PingPong(Time.time, blink.blinkTime)));
        //}
        //if (isSelected == false)
        //{
        //    thisDial.GetComponent<Renderer>().material.SetColor("EmissionColor", Color.clear);
        //}
    }
}
