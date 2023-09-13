using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gate : TriggerZone
{
    protected Timer _timer;

    public void Start()
    {
        _timer = FindAnyObjectByType<Timer>();
    }

    //overloading
    public void ChangeColour(Renderer renderer)
    {
        renderer.material.color = new Color(Random.Range(0f, 1f),
                                                Random.Range(0f, 1f),
                                                Random.Range(0f, 1f));
    }
    public void ChangeColour(Renderer renderer, Color color)
    {
        renderer.material.color = color;
    }
}
