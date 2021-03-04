using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalerScript : MonoBehaviour
{
    private float speed = 1.5f;
    private Vector3 endScale = new Vector3(2f, 2f, 2f);

    void Update()
    {
        if(transform.localScale.y < endScale.y)
            ScaleTheObject();
    }

    private void ScaleTheObject()
    {
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f) * speed * Time.deltaTime;
    }
}
