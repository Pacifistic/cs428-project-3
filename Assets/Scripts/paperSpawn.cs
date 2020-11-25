using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class paperSpawn : MonoBehaviour
{
    public VRTK_InteractableObject machine;
    public GameObject paperPrefab;

    protected virtual void OnEnable() {
        machine.InteractableObjectUsed += InteractableObjectUsed;
    }

    void InteractableObjectUsed(object sender, InteractableObjectEventArgs e) {
        Instantiate(paperPrefab);
    }
}
