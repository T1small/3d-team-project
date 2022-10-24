using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject flyeyePrefab;
    [SerializeField]
    private float flyeyeInterval = 3.5f;
    [SerializeField]
    private GameObject goblinPrefab;
    [SerializeField]
    private float goblinInterval = 3.5f;
    [SerializeField]
    private GameObject mashroomPrefab;
    [SerializeField]
    private float mashroomInterval = 3.5f;
    void Start()
    {
        StartCoroutine(spawnEnemy(flyeyeInterval,flyeyePrefab));
        StartCoroutine(spawnEnemy(goblinInterval,goblinPrefab));
        StartCoroutine(spawnEnemy(mashroomInterval,mashroomPrefab));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnEnemy(float interval,GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy,new Vector3(Random.Range(-9f,9),Random.Range(-4f,4f),0),Quaternion.identity);
        StartCoroutine(spawnEnemy(interval,enemy)); 
    }
}
