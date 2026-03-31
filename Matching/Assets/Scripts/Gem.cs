using UnityEngine;

public class Gem : MonoBehaviour
{   
    public TileSpawner board;
    public Vector2Int gemPos;
    public TileSpawner.GemType gemType;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetUpGem(Vector2Int pos, TileSpawner _board)
    {
        gemPos= pos;
        board= _board;
    }
}
