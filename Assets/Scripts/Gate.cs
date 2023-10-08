using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] int value;

    [SerializeField] DeformationType gateType;
    [SerializeField] GateAppearance gateAppearance;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnValidate()
    {
        gateAppearance.UpdateVisual(gateType, value);
    }
}
