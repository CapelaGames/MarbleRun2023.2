using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    //Turning our class into a singleton
    public static Timer Instance;



    public bool isActivated = false;

    private float _currentTime = 0;
    [SerializeField]
    private TMP_Text _text;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        
    }

    void OnEnable()
    {
        _currentTime = 0;
        _text.text = _currentTime.ToString("F2");
    }
    void Update()
    {
        if (isActivated)
        {
            _currentTime += Time.deltaTime;
            _text.text = _currentTime.ToString("F2");
        }
    }
}
