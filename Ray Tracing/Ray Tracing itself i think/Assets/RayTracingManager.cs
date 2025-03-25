using UnityEngine;
using UnityEngine.Rendering;
using System.Collections.Generic;
using Unity.Mathematics;
using System.Linq;

[ExecuteAlways, ImageEffectAllowedInSceneView]
public class RayTracingManager : MonoBehaviour
{
    [SerializeField] bool useShaderInSceneView;
    [SerializeField] Shader rayTracingShader;
    Material rayTracingMaterial;

    struct RayTracingMaterial {
        public Color color;
    };

    struct Sphere {
        public Vector3 position;
        public float radius;
        public RayTracingMaterial material;
    };

    void OnRenderImage(RenderTexture src, RenderTexture target) {
        Debug.Log("Onrenderimage");
        // Only in Game View or when I want it activated in Scene View
        if (Camera.current.name != "SceneCamera" || useShaderInSceneView) {
            ShaderHelper.InitMaterial(rayTracingShader, ref rayTracingMaterial);
            UpdateCameraParams(Camera.current);
            Graphics.Blit(null, target, rayTracingMaterial);
        }
        else {
            Graphics.Blit(src, target);
        }
    }

    void UpdateCameraParams(Camera cam) {
        float camHeight = cam.nearClipPlane * Mathf.Tan(cam.fieldOfView * 0.5f * Mathf.Deg2Rad) * 2;
        float camWidth = camHeight * cam.aspect;

        GameObject[] sphereObjects = GameObject.FindGameObjectsWithTag("Sphere");
        Sphere[] spheres = new Sphere[sphereObjects.Length];

        for (int i = 0; i < sphereObjects.Length; i++) {
            spheres[i].position = sphereObjects[i].transform.position;
            spheres[i].radius = sphereObjects[i].transform.localScale.x;
            spheres[i].material = new RayTracingMaterial();
            spheres[i].material.color = new Color(1,1,1,1);
        }        

        rayTracingMaterial.SetVector("ViewParams", new Vector3(camWidth, camHeight, cam.nearClipPlane));
        rayTracingMaterial.SetMatrix("CamLocalToWorldMatrix", cam.transform.localToWorldMatrix);
    }
}
