using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class InputManager : MonoBehaviour
{
    private SceneController _sceneController;
    private Controls.GameActions _controls;

    private Coroutine _restartCoroutine;

    [SerializeField]
    private GameObject _restartUI;
    [SerializeField]
    private Image _restartFill;
    [SerializeField, Range (0.1f, 1f)]
    private float _restartPushInSec = 0.25f;

    private void OnRestartPerformed(InputAction.CallbackContext obj)
    {
        _restartUI.SetActive(true);
        _restartCoroutine = StartCoroutine(Restarter());
    }

    private string Restarter()
    {
        throw new NotImplementedException();
    }

    private void OnRestartCanceled(InputAction.CallbackContext obj)
    {
        StopCoroutine(_restartCoroutine);
        _restartFill.fillAmount = 0f;
        _restartUI.SetActive(false);
    }


}
