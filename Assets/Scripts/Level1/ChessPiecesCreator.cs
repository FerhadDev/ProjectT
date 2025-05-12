using UnityEngine;

public class ChessPiecesCreator : MonoBehaviour
{
    public GameObject _ChessPiece;
    //position and team for eatch chesspiece
    private GameObject[,] _positions = new GameObject[6, 8];
    private GameObject[] PlayerBlack = new GameObject[6];
    private GameObject[] PlayerWhite = new GameObject[6];
    private string CurrentPlayer = "white";
    private bool GameOver = false;

    void Start()
    {
        PlayerWhite = new GameObject[]
        {
            Create("white_queen" , 1 ,0,"WhiteMan") , Create("white_king" , 3 ,0, "WhiteMan") ,
            Create("white_knight" , 5 ,0, "WhiteMan") , Create("white_bishop" , 0 ,1, "WhiteMan") ,
            Create("white_pawn" , 2 , 1, "WhiteMan") , Create("white_rook" , 4 ,1,"WhiteMan") 
        };
        PlayerBlack = new GameObject[]
        {
            Create("black_knight" , 0 ,7, "BlackMan") , Create("black_king" , 2 ,7, "BlackMan") ,
            Create("black_queen" , 4 ,7, "BlackMan") , Create("black_rook" , 1 ,6, "BlackMan") , 
            Create("black_pawn" , 3 ,6, "BlackMan") , Create("black_bishop" , 5 ,6, "BlackMan") ,
        };
        // Set all pice positions on the position board
        for (int i = 0; i < PlayerBlack.Length; i++)
        {
            SetPosition(PlayerBlack[i]);
            SetPosition(PlayerWhite[i]);
        }
    }
    public GameObject Create(string name, int x, int y, string tag)
    {
        GameObject obj = Instantiate(_ChessPiece, new Vector3(0, 0, -1), Quaternion.identity);
        obj.tag = tag;
        ChessMan cm = obj.GetComponent<ChessMan>();
        cm.name = name;
        cm.SetXBoard(x);
        cm.SetYBoard(y);
        cm.Activate();
        return obj;
    }
    public void SetPosition(GameObject obj)
    {
        ChessMan cm = obj.GetComponent<ChessMan>();
        _positions[cm.GetXBoard(), cm.GetYBoard()] = obj;
    }
}
