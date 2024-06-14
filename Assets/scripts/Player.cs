using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D rigidbody2D;
    //usamos esta variable para modificarla desde el editor.
    [SerializeField] private float   upForce = 350f;
    private bool isDead;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        //para detectar su cliqueo el boton isquierdo del mause
        if(Input.GetMouseButtonDown(0) && !isDead)
        {
            Flap();
        }
    }
    private void Flap()
    {
        //empieza aletear
        animator.SetTrigger("Flap");
        // le asigno velocidad 0 y luego hace el salto
        rigidbody2D.velocity = Vector2.zero;
        rigidbody2D.AddForce(Vector2.up * upForce);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        animator.SetTrigger("Die");
        GameManager.Instance.GameOver();
    }
}
