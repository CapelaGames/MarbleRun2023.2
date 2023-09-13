using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Marble/Weapon")]
public class ScriptableExample : ScriptableObject
{
    public float damage = 20f;
    public float health = 99f;
}

[CreateAssetMenu(fileName = "Weapon2", menuName = "Marble/Weapon2")]
public class ScriptableExample2 : ScriptableObject
{
    public float damage = 20f;
    public float health = 99f;
}
