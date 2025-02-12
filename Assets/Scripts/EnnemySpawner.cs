using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    [SerializeField]
    private float minSpawnRate;
    [SerializeField]
    private float maxSpawnRate;

    private float SpawnCD;
    private GM gameManager;

    // Start is called before the first frame update
    void Awake()
    {
        SetSpawnCD();
        gameManager = GameObject.Find("GM").GetComponent<GM>();

    }

    // Update is called once per frame
    void Update()
    {
        SpawnCD-= Time.deltaTime;

        if (SpawnCD < 0 && gameManager.defeat==false)
        { 
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);

            SetSpawnCD();
        
        }
        
    }

    private void SetSpawnCD()
    {
    
        SpawnCD = Random.Range(minSpawnRate, maxSpawnRate);
    }



}
