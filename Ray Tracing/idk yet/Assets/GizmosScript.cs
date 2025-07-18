using Unity.Collections;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.Rendering;

public class GizmosScript : MonoBehaviour
{
    public Vector2Int debugPointCount;

    void OnDrawGizmos()
    {
        Camera cam = Camera.main;
        Transform camT = cam.transform;

        float camHeight = cam.nearClipPlane * Mathf.Tan(cam.fieldOfView * 0.5f * Mathf.Deg2Rad) * 2;
        float camWidth = camHeight * cam.aspect;

        Vector3 bottomLeftLocal = new Vector3(-camWidth / 2, -camHeight / 2, cam.nearClipPlane);
        Vector3 testPoint = camT.position + camT.right * bottomLeftLocal.x + camT.up * bottomLeftLocal.y + camT.forward * bottomLeftLocal.z;
        Gizmos.DrawSphere(testPoint, 0.01f);

        for (int x = 0; x < debugPointCount.x; x++) {
            float tx = x / (debugPointCount.x - 1f);
            for (int y = 0; y < debugPointCount.y; y++) {
                float ty = y / (debugPointCount.y - 1f);

                Vector3 pointLocal = bottomLeftLocal + new Vector3(camWidth * tx, camHeight * ty, 0);
                Vector3 point = camT.position + camT.right * pointLocal.x + camT.up * pointLocal.y + camT.forward * pointLocal.z;
                Vector3 dir = (point - camT.position).normalized;
        
                Gizmos.color = Color.white;
                Gizmos.DrawSphere(point, 0.01f);
                Gizmos.color = Color.red;
                Gizmos.DrawRay(camT.position, dir);
            }
        }
    }
}
