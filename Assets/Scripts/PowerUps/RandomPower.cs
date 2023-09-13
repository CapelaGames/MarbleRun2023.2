using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPower : ItemBox
{
    [SerializeField]
    List<Powerup> _powerupList;

    public override void Activate(Collider other)
    {
        base.Activate(other);
        
        int randomIndex = Random.Range(0, _powerupList.Count);
        _powerupList[randomIndex].Activate(other);
    }
}
