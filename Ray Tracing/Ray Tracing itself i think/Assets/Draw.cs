using UnityEditor;
using UnityEngine;

public static class Draw {
    public static void Arrow(Vector3 origin, Vector3 direction, Color color, float thickness) {
        Vector3 endPoint = origin + direction;
        Handles.DrawBezier(origin, endPoint, origin, endPoint, color, null, thickness);
        Handles.ConeHandleCap(0, endPoint, Quaternion.LookRotation(direction, Vector3.up), thickness / 60, EventType.Repaint);
    }
}