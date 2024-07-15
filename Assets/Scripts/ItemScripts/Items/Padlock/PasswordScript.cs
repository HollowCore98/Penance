using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PasswordScript : MonoBehaviour
{
    PadlockMovement padlockMovement;

    public int[] padlockPassword = { 0, 0, 0, 0 };
    private string x;

    private void Awake()
    {
        padlockMovement = FindFirstObjectByType<PadlockMovement>();
    }

    public void Password()
    {
        if (padlockMovement.numberArray.SequenceEqual(padlockPassword))
        {
            Debug.Log("correct");
           for (int i = 0; i< padlockMovement.dial.Count; i++)
            {
                padlockMovement.dial[i].GetComponent<PadlockColor>().isSelected = false;
                padlockMovement.dial[i].GetComponent<PadlockColor>().BlinkMaterial();
            }
        }
    }
}
