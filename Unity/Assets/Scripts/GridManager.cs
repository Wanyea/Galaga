using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int [,] Grid;
    int vertical, horizatal, columns, rows;
    // Start is called before the first frame update
    void Start()
    {
        vertical = (int)Camera.main.orthographicSize;
        horizatal = vertical * (Screen.width / Screen.height);
        columns = horizatal * 2;
        rows = vertical * 2;
        Grid = new int[columns, rows];
        for(int i = 0; i < columns; i++) 
            {
                for(int j = 0; j < rows; j++) {
                Grid[i, j] = Random.Range(0, 10);
                SpawnTile(i, j, Grid[i, j]); 
            }
        }
    }

    public void SpawnTile(int x, int y, int value) 
    {
        GameObject g = new GameObject("X: " + x + "Y: " + y);
        g.transform.position = new Vector3(x - (horizatal - 0.5f), y - (vertical - 0.5f));
    }
}
