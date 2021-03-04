using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] snowmanPrefabs;

    private GameObject currentSnowman;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DestroyPrevSnowman();
            CreateRandomSnowman();
        }
    }

    private void CreateRandomSnowman()
    {
        GameObject randomSnowman = snowmanPrefabs[Random.Range(0, snowmanPrefabs.Length)];

        currentSnowman = Instantiate(randomSnowman, Vector3.zero, Quaternion.identity);
    }

    private void DestroyPrevSnowman()
    {
        if (currentSnowman)
        {
            Destroy(currentSnowman);
        }
        else
        {
            return;
        }
    }
}
