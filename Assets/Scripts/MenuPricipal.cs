using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    [Header("Escena a cargar")]
    [SerializeField] private string nombreEscenaJuego;

    public void IniciarJuego()
    {
        if (!string.IsNullOrEmpty(nombreEscenaJuego))
        {
            SceneManager.LoadScene(nombreEscenaJuego);
        }
        else
        {
            Debug.LogWarning("No se asignó el nombre de la escena en el Inspector.");
        }
    }

    public void SalirJuego()
    {
        Debug.Log("Saliendo del juego...");

        Application.Quit();
    }
}