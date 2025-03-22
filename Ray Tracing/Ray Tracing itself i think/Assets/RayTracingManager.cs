using UnityEngine;
using UnityEngine.Rendering;
using System.Collections.Generic;

[ExecuteAlways, ImageEffectAllowedInSceneView]
public class RayTracingManager : MonoBehaviour
{
    [SerializeField] bool useShaderInSceneView;
    [SerializeField] Shader rayTracingShader;
    Material rayTracingMaterial;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start() {

    }

    private void Update() {
        
    }

    void OnRenderImage(RenderTexture src, RenderTexture target) {
        Debug.Log("OnRenderImage");
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

        rayTracingMaterial.SetVector("ViewParams", new Vector3(camWidth, camHeight, cam.nearClipPlane));
        rayTracingMaterial.SetMatrix("CamLocalToWorldMatrix", cam.transform.localToWorldMatrix);
    }
}
