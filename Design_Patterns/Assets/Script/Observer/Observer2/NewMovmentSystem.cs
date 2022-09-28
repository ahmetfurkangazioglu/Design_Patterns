using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovmentSystem : MonoBehaviour
{

    private void Start()
    {
        NewMovmentPanel.OnButtonClicked += Move;
    }
    private void OnDestroy()
    {
        NewMovmentPanel.OnButtonClicked -= Move;
    }
    public void Move(Vector3 direction) => transform.Translate(direction);
}
