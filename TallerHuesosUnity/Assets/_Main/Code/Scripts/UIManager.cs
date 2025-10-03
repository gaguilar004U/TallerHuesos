using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    /*void Start()
    {
                
    }

    void Update()
    {*/
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
//}
