using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Powerup : TriggerZone
{
    public float Duration = 2f;
    public float Cooldown = 1f;

    public bool PowerUpReady = true;

    private Collider _collider;

    private void Awake()
    {
        _collider = GetComponent<Collider>();
    }
    public override void Activate(Collider other)
    {
        StartCoroutine(UsePowerup());
    }
    protected IEnumerator UsePowerup()
    {
        PowerUpReady = false;
        _collider.enabled = false;
         yield return new WaitForSeconds(Cooldown);
        PowerUpReady = true;
        _collider.enabled = true;
    }
}
