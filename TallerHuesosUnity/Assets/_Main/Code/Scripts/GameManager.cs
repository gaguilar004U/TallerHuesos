using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
ESTADO: COMPLETADO✅
*/
public class GameManager : MonoBehaviour
{

    public UIManager uiManager;
    public string estado = "Play";
    [SerializeField]
    public int _puntos = 0;
    [SerializeField]
    public int _vidas = 5;
    [SerializeField]
    public bool _llave = false;

    void Start()
    {
        uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        EstadoDelJugador(estado);
    }

    public void SumarPuntos(int cantidad)
    {
        _puntos += cantidad;
    }
    public void Vidas(int cantidad)
    {
        _vidas += cantidad;
        if (_vidas <= 0)
        {
            EstadoDelJugador("Perdiste");
            //ReiniciarEscena();
        }
    }
    public void TieneLaLlave(bool estado)
    {
        _llave = true;
    }
    public void ReiniciarEscena()
    {
        SceneManager.LoadScene(0);
    }
    public void EstadoDelJugador(string estado)
    {
        switch (estado)
        {
            case "Play":
                Time.timeScale = 1;
                break;
            case "Pause":
                Time.timeScale = 0;
                break;
            case "Ganaste":
                SceneManager.LoadScene(2);
                break;
            case "Perdiste":
                SceneManager.LoadScene(1);
                break;
            case "Salir":
                Application.Quit();
                break;
        }
    }
}
