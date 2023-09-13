using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPower : Powerup
{
    public float SpeedBoost = 2f;

    public override void Activate(Collider other)
    {
        base.Activate(other);

        Rigidbody marbleRB = other.GetComponent<Rigidbody>();

        if (marbleRB != null)
        {
            marbleRB.velocity *= SpeedBoost;
        }
    }
}
