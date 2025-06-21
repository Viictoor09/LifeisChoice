using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Random = UnityEngine.Random;
using UnityEngine.Tilemaps;

public class RandomWalkGeneration : MonoBehaviour
{
    [SerializeField]
    protected Vector2Int startPosition = Vector2Int.zero;

    [SerializeField]
    private int iterations = 10;
    [SerializeField]
    public int walkLength = 10;
    [SerializeField]
    public bool startRandomlyEachIteration = true;

    [SerializeField]
    private TileMapVisualizer tilemapVisualizer;
    public void RunProceduralGeneration()
    {
        HashSet<Vector2Int> floorPosition = RunRandomWalk();
        tilemapVisualizer.Clear();
        tilemapVisualizer.PaintFloorTiles(floorPosition);
    }


    protected HashSet<Vector2Int> RunRandomWalk()
    {
        var currentPosition = startPosition;
        HashSet<Vector2Int> floorPosition = new HashSet<Vector2Int>();
        for (int i = 0; i < iterations; i++)
        {
            var path = ProceduralGeneration.SimpleRandomWalk(currentPosition, walkLength);
            floorPosition.UnionWith(path);
            if (startRandomlyEachIteration)
            {
                currentPosition = floorPosition.ElementAt(Random.Range(0, floorPosition.Count));
            }

        }
        return floorPosition;
    }
}

