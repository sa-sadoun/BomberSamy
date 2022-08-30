using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;


public class WallDecrease : MonoBehaviour
{
    // Start is called before the first frame update
    public Tilemap tiles;
    public Tile tile;

    public Vector3Int position;
    int topleft = -7, topright = 5 , niv = 0 ;

    public static float timeleft = 20f;
    public Text text1;

  
    // Update is called once per frame
    void Update()
    {
        
        timeleft -= Time.deltaTime;
        
        if(timeleft <=10)
            text1.color=Color.red;
        double t = Mathf.Round(timeleft);
        text1.text = t.ToString();

        if(timeleft<0)
            
        {
            timeleft = 20;
            position.x = topright;
            for (int i = topleft+1; i < topright; i++)
            {
                position.y=i;
                tiles.SetTile(position, tile);   
            }

            position.x = topleft;
            for (int i = topleft+1; i < topright; i++)
            {
                position.y=i;
                tiles.SetTile(position, tile);   
            }
            position.y = topright-1;
            for (int i = topleft; i < topright; i++)
            {
                position.x=i;
                tiles.SetTile(position, tile);   
            }

            position.y = topleft+1;
            for (int i = topleft; i <= topright; i++)
            {
                position.x=i;
                tiles.SetTile(position, tile);   
            }
            // if(niv == 1)
            // {
                topleft = topleft + 1;
                topright = topright - 1;
                niv = niv + 1;
                System.Threading.Thread.Sleep(1000);
/*             }
            else if(niv == 2)
            {
                topleft = topleft + 1;
                topright = topright - 1;
                niv = niv + 1;
            }
            else if(niv == 3)
            {
                topleft = topleft + 1;
                topright = topright - 1;
                niv = niv + 1;
            } */
            
        }
    
    }
}
