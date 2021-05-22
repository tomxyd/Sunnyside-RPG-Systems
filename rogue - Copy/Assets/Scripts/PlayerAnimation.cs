using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    private PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        player = GetComponentInParent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Speed", player.moveDir.magnitude);
        anim.SetFloat("rollSpeed", player.rollSpeed);
    }
    public void SetTrigger(string trigger)
    {
        anim.SetTrigger(trigger);
    }
}
