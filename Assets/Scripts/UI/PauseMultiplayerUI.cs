// Ignore Spelling: Multiplayer

using UnityEngine;

public class PauseMultiplayerUI : MonoBehaviour
{
    private void Start()
    {
        KitchenGameManager.Instance.OnMultiPlayerGamePaused += KitchenGameManager_OnMultiPlayerGamePaused;
        KitchenGameManager.Instance.OnMultiPlayerGameUnpaused += KitchenGameManager_OnMultiPlayerGameUnpaused;
        Hide();
    }

    private void KitchenGameManager_OnMultiPlayerGameUnpaused(object sender, System.EventArgs e)
    {
        Hide();
    }

    private void KitchenGameManager_OnMultiPlayerGamePaused(object sender, System.EventArgs e)
    {
        Show();
    }

    private void Show()
    {
        gameObject.gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
