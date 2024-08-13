using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PadlockMovement : MonoBehaviour
{
    PadlockColor padlockColor;
    PasswordScript passwordScript;

    float axis;
    

    [HideInInspector]
    public List<GameObject> dial = new List<GameObject>();
    private int moveDial = 0;
    private int changeDial = 0;

    [HideInInspector]
    public int[] numberArray = { 1, 0, 0, 0 };
    private int numberDial = 0;
    private bool itsColorActive = false;

    private void Awake()
    {
        passwordScript = FindFirstObjectByType<PasswordScript>();
        padlockColor = FindFirstObjectByType<PadlockColor>();

        dial.Add(GameObject.Find("Ruller1"));
        dial.Add(GameObject.Find("Ruller2"));
        dial.Add(GameObject.Find("Ruller3"));
        dial.Add(GameObject.Find("Ruller4"));

        foreach (GameObject _dial in dial)
        {
            _dial.transform.Rotate(-144, 0, 0, Space.Self);
        }
    }

    private void Update()
    {
        passwordScript.Password();
        DialMovement();
        RotateDial();
    }
   public void DialMovement()
    {
        // input izq - derc
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            //Debug.Log(numberDial);
            itsColorActive = true;
            changeDial ++;
            numberDial += 1;
            if(numberDial > 3)
            {
                numberDial = 0;
            }
        }
        
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            //Debug.Log(numberDial);
            itsColorActive = true;
            changeDial --;
            numberDial -= 1;
            if (numberDial < 0)
            {
                numberDial = 3;
            }
        }
        changeDial = (changeDial + dial.Count) % dial.Count;

        for (int i = 0; i < dial.Count; i++)
        {
            if (itsColorActive)
            {
                if (changeDial == i)
                {
                    dial[i].GetComponent<PadlockColor>().isSelected = true;
                    dial[i].GetComponent<PadlockColor>().BlinkMaterial();
                }
                else
                {
                    dial[i].GetComponent<PadlockColor>().isSelected = false;
                    dial[i].GetComponent<PadlockColor>().BlinkMaterial();
                }
            }
        }
    }
    public void RotateDial()
    {
        // inputs arriba - abajo
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            //Debug.Log(numberArray);
            itsColorActive = true;
            moveDial = 36;
            dial[changeDial].transform.Rotate(-moveDial, 0, 0, Space.Self);
            numberArray[changeDial] += 1;

            if (numberArray[changeDial] > 9)
            {
                numberArray[changeDial] = 0;
            }
        }
        if(Keyboard.current.sKey.wasPressedThisFrame)
        {
            itsColorActive = true;
            moveDial = 36;
            dial[changeDial].transform.Rotate(moveDial, 0, 0, Space.Self);
            numberArray[changeDial] -= 1;

            if (numberArray[changeDial] < 0)
            {
                numberArray[changeDial] = 9;
            }
        }
    }
}
