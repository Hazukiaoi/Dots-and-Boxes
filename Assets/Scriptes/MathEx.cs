using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathEx
{
    /// <summary>
    /// 计算射线和平面的交点
    /// </summary>
    /// <param name="ray"></param>
    /// <param name="planeNormal"></param>
    /// <param name="planePostion"></param>
    /// <returns></returns>
    static public Vector3 RayCastPlane(Ray ray, Vector3 planeNormal, Vector3 planePostion)
    {
        float t = Vector3.Dot(planePostion  - ray.origin, planeNormal) / Vector3.Dot(ray.direction, planeNormal);
        return ray.GetPoint(t);
    }
}
