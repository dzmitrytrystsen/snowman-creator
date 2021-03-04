using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    private float timeToTeleport = 1f;
    private float counter = 0f;

    void Update()
    {
        counter += Time.deltaTime;

        if (counter > timeToTeleport)
        {
            TeleportTheObject();
        }
    }

    private void TeleportTheObject()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-3f, 3f), 0f, Random.Range(-3f, 3f));

        transform.position = randomPosition;

        counter = 0f;
    }
}
