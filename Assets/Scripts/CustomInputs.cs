using UnityEngine;

public class CustomInputs : MonoBehaviour
{
    [SerializeField] GameObject MenuCanvas;

    private void Start()
    {
        if (MenuCanvas != null)
        {
            MenuCanvas.SetActive(false);
        }
    }

    public void OnMenu()
    {
        MenuCanvas.SetActive(!MenuCanvas.activeInHierarchy);
    }

    public void OnExitButtonPressed()
    {
        Application.Quit();
    }
}
