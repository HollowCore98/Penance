using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PadlockMovement : MonoBehaviour
{
    PadlockColor padlockColor;
    PasswordScript passwordScript;


    [HideInInspector]
    public List<GameObject> dial = new List<GameObject>();
    private int moveDial = 0;
    private int changeDial = 0;

    [HideInInspector]
    public int[] numberArray = { 0, 0, 0, 0 };
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
        //DialMovement();
        //RotateDial();
        passwordScript.Password();
    }
//no funciona 
   public void DialMovement(InputAction.CallbackContext context)
    {
        // input izq - derc
        if (context.phase == InputActionPhase.Performed)
        {
            itsColorActive = true;
            changeDial ++;
            numberDial += 1;
            if(numberDial > 3)
            {
                numberDial = 0;
            }
        }
        //if ()
        else
        {
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
    //funciona 
    public void RotateDial(InputAction.CallbackContext context)
    {
        // inputs arriba - abajo
        if (context.phase == InputActionPhase.Performed)
        {
            itsColorActive = true;
            moveDial = 36;
            dial[changeDial].transform.Rotate(-moveDial, 0, 0, Space.Self);
            numberArray[changeDial] += 1;

            if (numberArray[changeDial] > 9)
            {
                numberArray[changeDial] = 0;
            }
        }
        //if ()
        else
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
