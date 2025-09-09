using UnityEngine;

/*
ESTADO: COMPLETADO✅
*/
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb2d;

    [SerializeField]
    public float x = 2f;
    [SerializeField]
    public float y = 2f;
    [SerializeField]
    public int force = 100;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb2d.AddForce(new Vector2(-x, 0) * force);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb2d.AddForce(new Vector2(x, 0) * force);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(new Vector2(0, y) * force);
        }

    }
}