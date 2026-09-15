using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int width = 8;
    public int height = 8;
    public float cellSize = 1f;

    // Zamienia współrzędne siatki (np. 3,2) na pozycję w świecie
    public Vector3 GridToWorld(int x, int y)
    {
        return new Vector3(x * cellSize, y * cellSize, 0);
    }

    // Rysowanie siatki w edytorze - pomocnicze, nie wpływa na grę
    void OnDrawGizmos()
    {
        Gizmos.color = Color.gray;
        for (int x = 0; x <= width; x++)
            Gizmos.DrawLine(new Vector3(x, 0, 0), new Vector3(x, height, 0));
        for (int y = 0; y <= height; y++)
            Gizmos.DrawLine(new Vector3(0, y, 0), new Vector3(width, y, 0));
    }
}