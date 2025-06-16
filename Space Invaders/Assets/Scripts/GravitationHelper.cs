using UnityEngine;

public static class GravitationHelper
{
    public static void ApplyGravitation(Transform transform, Rigidbody2D rb2D, float gravitationConstant)
    {
        GameObject[] heavyObjects = GameObject.FindGameObjectsWithTag("Heavy");

        foreach (GameObject heavyObject in heavyObjects)
        {
            Vector2 offset = (Vector2)heavyObject.transform.position - (Vector2)transform.position;
            if (offset.magnitude > 0.5f)
            {
                rb2D.AddForce((offset.normalized * heavyObject.GetComponent<Rigidbody2D>().mass * gravitationConstant) / Mathf.Pow(offset.magnitude / 3, 2));
            }
        }
    }
}
