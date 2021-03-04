using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongScript : MonoBehaviour
{
    public float speed = 1f;

    private Vector3 startPosition = new Vector3(0f, 0f, -3f);

    void Update()
    {
        PingPongTheObject();
    }

    private void PingPongTheObject()
    {
        transform.position = Vector3.Lerp(startPosition, -startPosition, Mathf.PingPong(Time.time, speed));
    }
}
