using UnityEngine;

[CreateAssetMenu(fileName = "GameState", menuName = "Scriptable Objects/GameState")]
public class GameState : ScriptableObject
{
    public int level;

    // ship
    public float shipAcceleration;
    public float shipRotation;
    public float dashForce;
    public float dashDelay;
    public float dashITime;
    public float hitITime;
    public float shootRate;
    public float hookForce;
    public int maxHealth;

    // aliens
    public int alienAmnt;
    public float alienSpawnTime;
    public float alienAcceleration;
    public int alienHealth;
    public int alienHitImpact;
}
