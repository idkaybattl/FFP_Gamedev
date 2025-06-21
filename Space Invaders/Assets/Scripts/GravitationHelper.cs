using UnityEngine;

public static class GravitationHelper
{
    public static void ApplyGravitation(Transform transform, Rigidbody2D rb2D)
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in enemies)
        {
            Vector2 offset = (Vector2)enemy.transform.position - (Vector2)transform.position;
            if (offset.magnitude > 0.5f)
            {
                rb2D.AddForce((offset.normalized * enemy.GetComponent<Rigidbody2D>().mass * rb2D.mass * Physics2D.gravity.magnitude) / offset.magnitude);
            }
        }
    }
}
