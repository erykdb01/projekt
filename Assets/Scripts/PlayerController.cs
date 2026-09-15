using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Unit selectedUnit;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            int x = Mathf.RoundToInt(mouseWorld.x);
            int y = Mathf.RoundToInt(mouseWorld.y);

            if (selectedUnit != null)
            {
                selectedUnit.MoveTo(x, y);
            }
        }
    }
}