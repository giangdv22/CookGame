// Ignore Spelling: Netcode

using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class TestingNetcodeUI : MonoBehaviour
{
    [SerializeField] private Button startHostButton;
    [SerializeField] private Button startClientButton;

    private void Awake()
    {
        startHostButton.onClick.AddListener(() =>
        {
            Debug.Log("Host");
            Hide();
            KitchenGameMultiplayer.Instance.StartHost();
        });

        startClientButton.onClick.AddListener(() =>
        {
            Debug.Log("Client");
            Hide();
            KitchenGameMultiplayer.Instance.StartClient();
        });
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
