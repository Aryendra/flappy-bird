using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columns : MonoBehaviour
{
    public int columnpoolsize = 5;
    public GameObject columnprefab;
    public float spawnRate = 4f;
    public float columnmin = -1f;
    public float columnmax = 3.5f;
    private GameObject[] column;
    private Vector2 objectpoolposition = new Vector2(-15f, -25f);
    private float timesincelastspawned;
    private float spawnxposition = 10f;
    private int currentcolumn = 0;
    private void Start()
    {
        column = new GameObject[columnpoolsize];
        for (int i = 0; i < columnpoolsize; i++)
        {
            column[i] = (GameObject)Instantiate(columnprefab, objectpoolposition, Quaternion.identity);
        }
    }
    private void Update()
    {
        timesincelastspawned += Time.deltaTime;
        if (GameController.instance.gameOver == false && timesincelastspawned >= spawnRate)
        {
            timesincelastspawned = 0;
            float spawnYposition = Random.Range(columnmin, columnmax);
            column[currentcolumn].transform.position = new Vector2(spawnxposition, spawnYposition);
            currentcolumn++;
            if (currentcolumn >= columnpoolsize)
            {
                currentcolumn = 0;
            }
        }
    }

}   
