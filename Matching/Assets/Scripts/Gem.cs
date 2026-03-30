using UnityEngine;

public class Gem : MonoBehaviour
{   
    public TileSpawner board;
    public Vector2Int gemPos;
    public TileSpawner.GemType gemType;
    private Vector2 firstTouchPos;
    private Vector2 lastTouchPos;
    private bool mousePressed=false;
public float swipleAngle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(mousePressed&&Input.GetMouseButtonUp(0))
        {
            lastTouchPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            CalculateAngle();

        }
    }

    public void SetUpGem(Vector2Int _gemPos,  TileSpawner _board)
    {
        gemPos = _gemPos;
        
        board = _board;
    }

    public void OnMouseDown()
    {
        if(board.currentState == TileSpawner.BoardState.move)
        {
            mousePressed = true;
            Debug.Log("Gem Clicked");
            firstTouchPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }
    }
    private void CalculateAngle()
    {
        swipleAngle = Mathf.Atan2(lastTouchPos.y - firstTouchPos.y,lastTouchPos.x - firstTouchPos.x);
        swipleAngle = swipleAngle *180 / Mathf.PI;
        Debug.Log("swipeAngle"+ swipleAngle);
    }
}


