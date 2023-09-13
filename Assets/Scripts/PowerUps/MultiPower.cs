using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MultiPower", menuName = "Marble/Powerups/Multi")]
public class MultiPower : Powerup
{
    
    public override void Activate(Collider other)
    {
        Instantiate(other.gameObject);
    }
}
