using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGate : Gate
{
    public override void Activate(Collider other)
    {
        if (_timer != null)
        {
            _timer.isActivated = false;
        }
    }
}
