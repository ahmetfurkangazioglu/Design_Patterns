using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedState : ColorState
{
    public ColorState Yellow;
    public ColorState Blue;
    public override ColorState ChangeColor(Renderer renderer, AllColor color)
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            renderer.material = color.Yellow;
            return Yellow;
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
