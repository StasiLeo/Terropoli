using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentiMacchina : MonoBehaviour
{
    private Rigidbody Macchina;
    public Vector3 centromassa;
    private float VelBot = 30f;
    public float AccMax;
    public float Freno;
    public float SensGira;
    public float AngoloGira;
    void Start()
    {
        Macchina = GetComponent<Rigidbody>();
        Macchina.centerOfMass = centromassa;
    }

    void Update()
    {
        
    }
}
