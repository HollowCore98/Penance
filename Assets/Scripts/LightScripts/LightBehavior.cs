using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehavior : MonoBehaviour
{
    [SerializeField] private float timeToChangeState;
    [SerializeField] private int loopInteractions;

    private Light spotLight;
    private float timer;

    public GameManager GameManager
    {
        get => default;
        set
        {
        }
    }

    private void Awake()
    {
        spotLight = GetComponent<Light>();
    }


    void Update()
    {
        ChangeState();
    }

    private void ChangeState()
    {
        timer += Time.deltaTime;
        if(timer > timeToChangeState)
        {
            timer = 0;
            StopCoroutine(nameof(Flicker));
            StartCoroutine(nameof(Flicker));
        }
    }


    // llega al proyecto final??
    IEnumerator Flicker()
    {
        for (int i=0; i < loopInteractions; i++)
        {
            spotLight.enabled = !spotLight.enabled;
            yield return new WaitForSeconds(0.1f);
        }
        //termina el bucle de parpadeos y dejamos la luz encendida.
        spotLight.enabled = true; 
    }
}
