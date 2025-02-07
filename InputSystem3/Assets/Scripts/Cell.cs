using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cell : MonoBehaviour, IPointerEnterHandler,IPointerClickHandler, IPointerExitHandler
{
    [SerializeField]
    private MeshRenderer _focus;
    [SerializeField]
    private MeshRenderer _select;

    public Unit Unit { get; set; }

    public event System.Action<Cell> OnPointerClickEvent;

    public void SetSelect(Material material) 
        => (_select.enabled, _select.sharedMaterial) = (true, material);

    public void ResetSelect()
        => (_select.enabled) = (false);

    public void OnPointerClick (PointerEventData eventData)
        => OnPointerClickEvent?.Invoke(this);


    public void OnPointerEnter(PointerEventData eventData)
    {
        _focus.enabled = true;
        Debug.Log("Focus!");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _focus.enabled = false;
    }

    private void Start()
    {
        _focus.enabled = false;
        _select.enabled = false;
    }

}



    
   

    