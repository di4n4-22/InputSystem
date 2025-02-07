using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Unit : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    public Cell Cell { get; private set; }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Cell?.OnPointerEnter(eventData);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Cell?.OnPointerClick(eventData);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Cell?.OnPointerExit(eventData);
    }

    public void Move(Cell cell)
    {
        // Логика перемещения юнита на клетку
        StartCoroutine(MoveToCell(cell));
    }

    private IEnumerator MoveToCell(Cell cell)
    {
        Vector3 startPosition = transform.position;
        Vector3 targetPosition = cell.transform.position;
        float duration = 1.0f;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPosition;
        Cell = cell;
        cell.Unit = this;

        OnMoveEndCallback?.Invoke();
    }

    public event System.Action OnMoveEndCallback;
}

