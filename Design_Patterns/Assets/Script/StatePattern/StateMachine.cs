using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public ColorState currentState;
    Renderer objectRenderer;
    AllColor allColor;
    void Start()
    {
        objectRenderer = gameObject.GetComponent<Renderer>();
        allColor = gameObject.GetComponent<AllColor>();
    }
    void Update()
    {
        ChangeColors();
    }

    public void ChangeColors()
    {
        ColorState newState = currentState.ChangeColor(objectRenderer, allColor);
        if (currentState!=null)
        {
            currentState = newState;
        }
    }
}
