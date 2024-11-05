using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    public bool playerIsTouching = false;
    private void OnTriggerEffect2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneController.instance.NextLevel();
            playerIsTouching = true;
        }
    }
}
