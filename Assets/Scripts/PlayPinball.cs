using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class PlayPinball : MonoBehaviour
{
    public VRTK_InteractableObject pinball;
    public AudioSource sound;

    protected virtual void OnEnable() {
        pinball.InteractableObjectUsed += InteractableObjectUsed;
    }

    void InteractableObjectUsed(object sender, InteractableObjectEventArgs e) {
        sound.PlayOneShot(sound.clip);
    }
}
