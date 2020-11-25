using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class GetNear : MonoBehaviour
{

    private Animator anim;
    public VRTK_InteractableObject person;
    private AudioSource talk;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        talk = GetComponent<AudioSource>();
    }

    protected virtual void OnEnable() {
        person.InteractableObjectNearTouched += whenNear;
    }

    void whenNear(object sender, InteractableObjectEventArgs e) {
        anim.SetTrigger("near");
        talk.Play();
    }
}
