using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<bird>() != null)
        {
            GameController.instance.BirdScored ();
        }
    }
}    // Start is called before the first frame update
