using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] AiPrefabs;
    private float spawnRangeX = 30;
    private float spawnPosZ = 20;
    void Start()
    {
        
    }

    // Update is called once per frame
  

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

            int AiIndex= Random.Range(0,AiPrefabs.Length);
            Instantiate(AiPrefabs[AiIndex], AiPrefabs[AiIndex].transform.position, AiPrefabs[AiIndex].transform.rotation);
        }
    }
}
