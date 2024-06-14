using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgraundReapet : MonoBehaviour
{
    private float spriteWifth;
    // Start is called before the first frame update
    void Start()
    {   
        //graundCollider traempos el componente
        BoxCollider2D graundCollider = GetComponent<BoxCollider2D>();
        //cargamos el ancho del graund o sea -20
        spriteWifth = graundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        //verifica si la posicion en x es menor a 20
        if (transform.position.x < -spriteWifth)
        {
            ResetPosition();
        }
    }
    
    private void ResetPosition()
    {
        //2 por spriteWifth porque ahi 2 esenas (ground)
        transform.Translate(new Vector3(2 * spriteWifth, 0f, 0f));
    }
}
