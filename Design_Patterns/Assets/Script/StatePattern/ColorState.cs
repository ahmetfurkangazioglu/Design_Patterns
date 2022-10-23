using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ColorState:MonoBehaviour
{
    public abstract ColorState ChangeColor(Renderer renderer,AllColor color);
}
