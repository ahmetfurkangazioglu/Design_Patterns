using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowState : ColorState
{
    public ColorState Red;
    public ColorState Blue;
    public override ColorState ChangeColor(Renderer renderer, AllColor color)
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            renderer.material = color.Red;
            return Red;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            renderer.material = color.Blue;
            return Blue;
        }
        else
            return this;
    }
}
