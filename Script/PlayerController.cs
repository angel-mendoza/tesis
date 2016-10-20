using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float velocidadDeMovimiento;       //moveSpeed
    public float fuerzaDeSalto;               //jumpHeigth

    public Transform checkDelSuelo;           //groundCheck
    public float radioDelCheckDelSuelo;       // groundCheckRadius
    public LayerMask esSuelo;                 //whatIsGround
    private bool conectadoASuelo;             //grounded
    private bool dobleSalto;                  //dobleJump


	// Use this for initialization
	void Start () {
	    
	}

    void FixedUpdate()
    {
        conectadoASuelo = Physics2D.OverlapCircle(checkDelSuelo.position, radioDelCheckDelSuelo, esSuelo);
    }
	
	// Update is called once per frame
	void Update () {
	
        if (Input.GetKeyDown(KeyCode.Space) && conectadoASuelo)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, fuerzaDeSalto);
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadDeMovimiento,GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidadDeMovimiento, GetComponent<Rigidbody2D>().velocity.y);
        }
    }
}
