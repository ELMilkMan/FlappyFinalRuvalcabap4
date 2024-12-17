using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{

    public int columnPoolsize = 5;
    public GameObject columnprefab;
    public float spwanRate = 4f;
    public float columnMin = -1f;
    public float columnMax = 3.5f;
    private int currentColumn = 0;

    private GameObject[] columns;
    private Vector2 objectPoolPositon = new Vector2(-15, -25f);
    private float timeSinceLastSpawned;
    private float spwanXPositon = 10f;
    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[columnPoolsize];
        for (int i = 0; i < columnPoolsize; i++)
        {
            columns [i] = (GameObject)Instantiate (columnprefab, objectPoolPositon, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (GameController.instance.gameOver == false && timeSinceLastSpawned >= spwanRate)
        {
            
            timeSinceLastSpawned = 0;
            float spawnYPositon = Random.Range (columnMin, columnMax);
            columns[currentColumn].transform.position = new Vector2 (spwanXPositon, spawnYPositon);
            currentColumn++;
            if (currentColumn >= columnPoolsize)
            {
                currentColumn = 0;
            }
        }
    }
}
