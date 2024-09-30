using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuidaAutomatica : MonoBehaviour
{
    public float speed = 5f;
    public int direzione = 0;
    public float rayLength = 10f;
    public float rayOffset = 3f;
    Vector3 currentDirection;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 rayOrigin = transform.position + transform.forward * rayOffset;
        currentDirection = transform.forward;
        RaycastHit hit;
        Debug.DrawRay(rayOrigin, currentDirection * rayLength, Color.red);
        transform.Translate(currentDirection * speed * Time.deltaTime, Space.World);

        if (direzione == 0)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);    
        }
        else if (direzione == 1)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (direzione == 2)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (direzione == 3)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Physics.Raycast(rayOrigin, currentDirection, out hit, rayLength))
        {
            Debug.Log("Raggio ha colpito: " + hit.collider.name);

        }
    }
}
