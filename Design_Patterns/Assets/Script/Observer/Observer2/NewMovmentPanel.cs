using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewMovmentPanel : MonoBehaviour
{
    public static event Action<Vector3> OnButtonClicked;

    public void ForwardOnClick()
    {
        OnButtonClicked?.Invoke(Vector3.forward);
    }
    public void LeftOnClick()
    {

        OnButtonClicked?.Invoke(Vector3.left);
    }
    public void BackOnClick()
    {
        OnButtonClicked?.Invoke(Vector3.back);
    }
    public void RightOnClick()
    {
        OnButtonClicked?.Invoke(Vector3.right);
    }
}
