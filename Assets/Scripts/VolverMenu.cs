using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverMenu : MonoBehaviour
{
    [SerializeField] private string nombreEscenaMenu = "Menu";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(nombreEscenaMenu);
        }
    }
}