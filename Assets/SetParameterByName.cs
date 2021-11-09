using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetParameterByName : MonoBehaviour
{
    private FMOD.Studio.EventInstance instance;

    [FMODUnity.EventRef] public string fmodEvent;

    [SerializeField] [Range(0f, 100f)] private float TreasureDistance;
    [SerializeField] [Range(0f, 1f)] private float EnemyDistance;
    [SerializeField] [Range(1f, 5f)] private float playbacokSpeed;

    // Start is called before the first frame update
    void Start()
    {
        instance = FMODUnity.RuntimeManager.CreateInstance(fmodEvent);
        instance.start();
    }

    // Update is called once per frame
    void Update()
    {
        instance.setParameterByName("Enemy Distance", EnemyDistance);
        instance.setParameterByName("Treasure Distance", TreasureDistance);
        instance.setParameterByName("Thinking", EnemyDistance);
        instance.setPitch(playbacokSpeed);
    }
}
