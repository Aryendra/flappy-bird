using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columnnnnn : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<code>() != null)
        {
            GameController.instance.birdscored();

        }
    }
}
// Start is called before the first frame update
