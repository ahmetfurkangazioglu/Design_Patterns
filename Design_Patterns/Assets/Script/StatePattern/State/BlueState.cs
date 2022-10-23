using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueState : ColorState
{
    public ColorState Yellow;
    public ColorState Red;
    public override ColorState ChangeColor(Renderer renderer, AllColor color)
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            renderer.material = color.Yellow;
            return Yellow;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            renderer.material = color.Red;
            return Red;
        }
        else
            return this;
    }
}
