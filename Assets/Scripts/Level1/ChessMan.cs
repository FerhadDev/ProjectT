using UnityEngine;

public class ChessMan : MonoBehaviour
{
    //References
    public GameObject _Controller;
    public GameObject _movePlate;
    
    //Positions
    private int _xBoard = -1;
    private int _yBoard = -1;

    //Variable to keep track of "Black" player or "White" player
    private string Player;

    //Referances for all the sprites that the chesspiece can be
    public Sprite black_queen, black_knight, black_bishop, black_king, black_rook, black_pawn;
    public Sprite white_queen, white_knight, white_bishop, white_king, white_rook, white_pawn;

    public void Activate()
    {
        _Controller = GameObject.FindGameObjectWithTag("GameController");

        //take the Instantiated location and adjust the transform
        SetCoords();
        switch (this.name)
        {
            case "black_queen": this.GetComponent<SpriteRenderer>().sprite = black_queen; break;
            case "black_knight": this.GetComponent<SpriteRenderer>().sprite = black_knight; break;
            case "black_bishop": this.GetComponent<SpriteRenderer>().sprite = black_bishop; break;
            case "black_king": this.GetComponent<SpriteRenderer>().sprite = black_king; break;
            case "black_rook": this.GetComponent<SpriteRenderer>().sprite = black_rook; break;
            case "black_pawn": this.GetComponent<SpriteRenderer>().sprite = black_pawn; break;

            case "white_queen": this.GetComponent<SpriteRenderer>().sprite = white_queen; break;
            case "white_knight": this.GetComponent<SpriteRenderer>().sprite = white_knight; break;
            case "white_bishop": this.GetComponent<SpriteRenderer>().sprite = white_bishop; break;
            case "white_king": this.GetComponent<SpriteRenderer>().sprite = white_king; break;
            case "white_rook": this.GetComponent<SpriteRenderer>().sprite = white_rook; break;
            case "white_pawn": this.GetComponent<SpriteRenderer>().sprite = white_pawn; break;
        }
    }
    public void SetCoords()
    {
        float x = _xBoard;
        float y = _yBoard;

        x *= 1.2f;
        y *= 1.2f;

        x += -4.24f;
        y += -4.24f;
        this.transform.position = new Vector3(x, y, 1f);
    }
    public int GetXBoard()
    {
        return _xBoard;
    }
    public int GetYBoard()
    {
        return _yBoard;
    }
    public void SetXBoard(int x)
    {
        _xBoard = x;
    }
    public void SetYBoard(int y)
    {
        _yBoard = y;
    }
}
