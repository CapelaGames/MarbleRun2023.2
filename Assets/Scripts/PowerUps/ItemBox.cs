using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBox : TriggerZone
{
    public float Duration = 2f;
    public float Cooldown = 1f;

    public bool PowerupReady = true;

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
        PowerupReady = false;
        _collider.enabled = false;
         yield return new WaitForSeconds(Cooldown);
        PowerupReady = true;
        _collider.enabled = true;
    }
}
