using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] Tower towerPrefab;

    [SerializeField] bool isPlaceable;
    public bool IsPlaceable { get { return isPlaceable; } }

    GridManager gridMananger;
    Vector2Int coordinates = new Vector2Int();

    void Awake()
    {
        gridMananger = FindObjectOfType<GridManager>();
    }
    void Start()
    {
        if(gridMananger != null)
        {
            coordinates = gridMananger.GetCoordinatesFromPosition(transform.position);

            if(!isPlaceable )
            {
                gridMananger.BlockNode(coordinates);
            }
        }
    }

    void OnMouseDown()
    {
        if (isPlaceable)
        {
            bool isPlaced = towerPrefab.CreateTower(towerPrefab,transform.position);
            isPlaceable = !isPlaced;
        }
    }
}