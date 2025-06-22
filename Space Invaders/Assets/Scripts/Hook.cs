using UnityEngine;
using UnityEngine.InputSystem;

public class Hook : MonoBehaviour
{
    Rigidbody2D rb2D;

    InputAction mouseAction;
    Vector2 mousePosition;

    InputAction hookAction;
    bool hook;
    public float hookForce;

    GameObject[] poles;
    GameObject targetedPole;
    public GameObject target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mouseAction = InputSystem.actions.FindAction("Target");
        hookAction = InputSystem.actions.FindAction("Hook");

        poles = GameObject.FindGameObjectsWithTag("Pole");
        targetedPole = poles[0];

        rb2D = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint((Vector3)mouseAction.ReadValue<Vector2>());
        float minDistance = Vector2.Distance((Vector2)poles[0].transform.position, mousePosition);
        float currentDist;
        targetedPole = poles[0];

        for (int i = 1; i < poles.Length; i++)
        {
            currentDist = Vector2.Distance((Vector2)poles[i].transform.position, mousePosition);
            if (currentDist < minDistance)
            {
                minDistance = currentDist;
                targetedPole = poles[i];
            }
        }

        target.transform.position = targetedPole.transform.position;

        hook = hookAction.ReadValue<float>() > 0;
    }

    void FixedUpdate()
    {
        Vector2 offset = (Vector2)targetedPole.transform.position - (Vector2)transform.position;

        if (hook)
        {
            if (offset.magnitude > 1)
            {
                rb2D.AddForce(offset.normalized * hookForce / offset.magnitude);
            }
            else
            {
                rb2D.AddForce(offset * hookForce);
            }
        }
    }
}
