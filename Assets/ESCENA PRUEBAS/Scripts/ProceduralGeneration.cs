using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public static class ProceduralGeneration
{
    public static HashSet<Vector2Int> SimpleRandomWalk(Vector2Int startPosition, int walkLength)
    {
        HashSet<Vector2Int> path = new HashSet<Vector2Int>();
        path.Add(startPosition);
        var previousposition = startPosition;
        for (int i = 0; i < walkLength; i++)
        {
            var newPosition = previousposition + Direction2D.GetRandomCardinalDirection();
            path.Add(newPosition);
            previousposition = newPosition;
        }
        return path;
    }
}



public static class Direction2D
{
    public static List<Vector2Int> cardinalDIrectionsList = new List<Vector2Int>
    {
        new Vector2Int(0,1), //UP
        new Vector2Int(1,0),
        new Vector2Int(0,-1),
        new Vector2Int(-1,0),

    };
    public static Vector2Int GetRandomCardinalDirection()
    {
        return cardinalDIrectionsList[Random.Range(0, cardinalDIrectionsList.Count)];
    }
}