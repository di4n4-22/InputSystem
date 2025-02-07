using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;


public class GameInstaller : MonoBehaviour
{
    [SerializeField]
    private SceneController _controler;
    [SerializeField, Space(15f)]
    private CellPaletteSettings _cellPaletterSettings;
    public override void InstallBindings()
    {
        _controls = new Controls();
        _controls.Game.Enable();
        Container.BindInstance(_controls.Game).AsSingle();

        Container.BindInstance(_cellManager).AsSingle();
        Container.BindInstance(_controller).AsSingle();

        Container.BindInstance(_cellPalletteSettings).AsSingle();

        _cellManager.OneCellClicked += CellManagerOnOnCellClicked();
    }

    private void CellManagerOnOnCellClicked()
    {
        obj.SetSelect(_cellPalletteSettings.SelectCell);
    }
    private void OnDestroy()
    {
        _controls.Dispose();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
