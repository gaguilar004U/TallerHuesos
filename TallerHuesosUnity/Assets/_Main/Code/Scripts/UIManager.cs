using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _corazones;
    [SerializeField]
    private GameManager gameManager;
    public int vidasUI;
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
    }

    /*public void UpdateHearts(int vidasUI)
    {
        vidasUI = gameManager._vidas;
        for (int i = 0; i < _corazones.Length; i++)
        {
            // Activa solo los corazones menores al número de vidas actual
            _corazones[i].gameObject.SetActive(i < vidasUI);
        }

    }*/
}

