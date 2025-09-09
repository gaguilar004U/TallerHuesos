using UnityEngine;
using UnityEngine.SceneManagement;
/*
ESTADO: COMPLETADO✅
*/
public class GameManager : MonoBehaviour
{

    [SerializeField]
    private int _puntos;
    public int Puntos => _puntos; // Propiedad de solo lectura
    [SerializeField]
    private int _vidas = 10;
    public int CantVidas => _vidas;
    [SerializeField]
    private bool _llave = false;
    public bool Llave => _llave;


    public void SumarPuntos(int cantidad)
    {
        _puntos += cantidad;
    }
    public void Vidas(int cantidad)
    {
        _vidas += cantidad;
        if (_vidas <= 0)
        {
            ReiniciarEscena();
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
}
