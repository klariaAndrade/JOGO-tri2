using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatasCtrl : MonoBehaviour
{
    MoveToRef script;
    public GameObject player;

    Animator anim;

    void Start()
    {
        script = player.GetComponent<MoveToRef>();
        anim = player.GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("plataforms") || other.gameObject.layer == LayerMask.NameToLayer("Obstacles")) {
            script.noChao = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("plataforms") || other.gameObject.layer == LayerMask.NameToLayer("Obstacles")) {
            script.noChao = false;
        }
    }
}
