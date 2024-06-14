using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
   
    private void OnTriggerEnter2D()
    {
        GameManager.Instance.incleaseScore();
    }
}
