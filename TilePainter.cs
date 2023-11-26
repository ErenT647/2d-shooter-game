using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilePainter : MonoBehaviour
{
    public Tile tileSliced;



    public Tilemap tilemap;
    [ContextMenu("Place")]
    public void Place(Vector3Int position)
    {
        tilemap.SetTile(position, tileSliced);

    }
}
