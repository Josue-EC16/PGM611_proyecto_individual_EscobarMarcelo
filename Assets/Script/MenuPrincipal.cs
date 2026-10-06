using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour
{
    private void Start()
    {
        // Enlazar programáticamente los botones por si el serializador de Unity no los vinculó
        Button[] buttons = FindObjectsByType<Button>(FindObjectsSortMode.None);
        foreach (var btn in buttons)
        {
            if (btn.gameObject.name == "BotonJugar")
            {
                btn.onClick.RemoveAllListeners();
                btn.onClick.AddListener(Jugar);
            }
            else if (btn.gameObject.name == "BotonSalir")
            {
                btn.onClick.RemoveAllListeners();
                btn.onClick.AddListener(Salir);
            }
        }
    }

    public void Jugar()
    {
        Debug.Log("[MenuPrincipal] Cargando escena del juego (SampleScene)...");
        SceneManager.LoadScene("SampleScene");
    }

    public void Salir()
    {
        Debug.Log("[MenuPrincipal] Saliendo del juego...");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
