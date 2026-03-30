using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{   
     
     public GameObject tilePrefab;
    public int height;
    public int width;
    public GameObject [,] allTiles;
    public List<Gem> gems;
    public enum GemType {banana, blueberry, apple,pear,strawberry,orange,grapes};
    public enum BoardState{move,wait}
    public BoardState currentState = BoardState.move;

    void Awake()
    {
        allTiles = new GameObject[width,height];
        for(int x = 0; x<width; x++)
        {
            for(int y =0; y< height; y++)
            {   
                SpawnTile(x,y);
                
            }
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SpawnTile(int x, int y)
    {
        Vector2Int tilePos= new Vector2Int(x,y);
                GameObject tile = Instantiate(tilePrefab,new Vector3(tilePos.x,tilePos.y,0),Quaternion.identity);
                allTiles[x,y]= tile;
                tile.name = "Tile "+tilePos.x+","+tilePos.y;
                tile.transform.parent = this.transform;
                int gemToUSe= Random.Range(0,gems.Count);
                SpawnGem(tilePos,gems[gemToUSe]);
    }

    public void SpawnGem(Vector2Int pos, Gem _gem)
    {
    
        
        
        Gem currentGem = Instantiate(_gem,new Vector3(pos.x,pos.y,0),Quaternion.identity);
        currentGem.name = "Gem "+pos.x+","+pos.y;
        currentGem.gemPos = pos;
        currentGem.SetUpGem(pos,this);
        currentGem.transform.parent= this.transform;


    }

  /*  public void ChooseGemType(int _gemType, Vector2Int pos)
    {
        switch(_gemType)
        {
            case 0:
                {
                    return GemType.banana;
                }
            case 1:
                {
                    return GemType.blueberry
                }
        }
    }*/
}
