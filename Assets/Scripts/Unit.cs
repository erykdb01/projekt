using UnityEngine;

public class Unit : MonoBehaviour
{
    public int gridX;
    public int gridY;
    public float cellSize = 1f;

    public void MoveTo(int x, int y)
    {
        gridX = x;
        gridY = y;
        transform.position = new Vector3(x * cellSize, y * cellSize, 0);
    }
}