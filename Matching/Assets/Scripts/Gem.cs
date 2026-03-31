using UnityEngine;

public class Gem : MonoBehaviour
{   
    public TileSpawner board;
    public Vector2Int gemPos;
    public TileSpawner.GemType gemType;

    private Vector2 firstTouchPos;
    private Vector2 finalTouchPos;
    private bool mousePressed;
    private float swipeAngle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(mousePressed&& Input.GetMouseButtonUp(0))
        {
            mousePressed = false;
            finalTouchPos= Camera.main.ScreenToWorldPoint(Input.mousePosition);
            CalculateAngle();

        }
    }

    public void SetUpGem(Vector2Int pos, TileSpawner _board)
    {
        gemPos= pos;
        board= _board;
    }
    
    private void OnMouseDown()
    {
        Debug.Log("Mouse Down");
        firstTouchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePressed = true;
    }
    public void CalculateAngle()
    {
        swipeAngle = Mathf.Atan2(firstTouchPos.x-finalTouchPos.x,firstTouchPos.y-finalTouchPos.y);
        swipeAngle = swipeAngle*180/Mathf.PI;
        Debug.Log(swipeAngle);
    }
}
