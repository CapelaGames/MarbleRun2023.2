using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiPower : Powerup
{
    
    public override void Activate(Collider other)
    {
        base.Activate(other);

        Instantiate(other.gameObject);
    }
}
