using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellManager : MonoBehaviour
{
    private List<Cell> cells = new List<Cell>();

    private void Start()
    {
        cells.AddRange(FindObjectsOfType<Cell>());
        foreach (var cell in cells)
        {
            // Логика нахождения соседних клеток
            // Подписка на событие OnPointerClickEvent
        }
    }
}

