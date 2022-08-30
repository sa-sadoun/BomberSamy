using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WallDecrease : MonoBehaviour
{
    // Start is called before the first frame update
    public Tilemap tiles;
    public Tile tile;

    public Vector3Int position;

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButton(0))
        {
            position.x = 5;
            for (int i = -6; i <= 4; i++)
            {
                position.y=i;
                tiles.SetTile(position, tile);   
            }

            position.x = -7;
            for (int i = -6; i <= 4; i++)
            {
                position.y=i;
                tiles.SetTile(position, tile);   
            }

            position.y = 4;
            for (int i = -6; i < 5; i++)
            {
                position.x=i;
                tiles.SetTile(position, tile);   
            }

            position.y = -6;
            for (int i = -6; i <= 4; i++)
            {
                position.x=i;
                tiles.SetTile(position, tile);   
            }
        }
    }
}
