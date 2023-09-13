using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpeedPower", menuName = "Marble/Powerups/Speed")]
public class SpeedPower : Powerup
{
    public float SpeedBoost = 2f;

    public override void Activate(Collider other)
    {
        Rigidbody marbleRB = other.GetComponent<Rigidbody>();

        if (marbleRB != null)
        {
            marbleRB.velocity *= SpeedBoost;
        }
    }
}
