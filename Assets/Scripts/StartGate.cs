using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGate : Gate
{
    public override void Activate(Collider other)
    {
        ChangeColour(other.GetComponent<Renderer>());
        if(_timer != null)
        {
            _timer.isActivated = true;
        }
    }


    public override void Error(string message)
    {
        base.Error( "Start Gate: " + message);

    }

}
