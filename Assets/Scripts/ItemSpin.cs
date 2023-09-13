using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpin : MonoBehaviour
{
    [SerializeField]
    float _rotationSpeed = 20.0f;

    private void Update()
    {
        Vector3 addedRotation = new Vector3(0, _rotationSpeed, 0);

        transform.Rotate(addedRotation * Time.deltaTime, Space.World);
    }
}
