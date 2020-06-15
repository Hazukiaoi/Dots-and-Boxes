using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugDraw
{
    static public void DrawBounds(Bounds bounds, Color c)
    {
        Debug.DrawLine(bounds.min, bounds.max, c);
    }

}
