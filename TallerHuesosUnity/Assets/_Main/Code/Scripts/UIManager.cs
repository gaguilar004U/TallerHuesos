using UnityEditor.SearchService;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _corazones;
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private GameObject objetoLlave;
    public int vidasUI;
    public bool llaveUI;
    void Start()
    {
        vidasUI = gameManager._vidas;
        for (int i = 0; i < _corazones.Length; i++)
        {
            _corazones[i].SetActive(true);
        }
    }
    void Update()
    {
        vidasUI = gameManager._vidas;
        for (int i = 0; i < _corazones.Length; i++)
        {
            // Activa solo los corazones menores al número de vidas actual
            _corazones[i].gameObject.SetActive(i < vidasUI);
        }
        llaveUI = gameManager._llave;
        if (objetoLlave != null)
        {
            objetoLlave.SetActive(llaveUI);
        }
    }
    
}

