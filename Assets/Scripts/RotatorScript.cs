using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorScript : MonoBehaviour
{
    private float speed = 100f;

    void Update()
    {
        RotateTheObject();
    }

    private void RotateTheObject()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
