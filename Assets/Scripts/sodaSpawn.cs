using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class sodaSpawn : MonoBehaviour
{
    public VRTK_InteractableObject machine;
    public GameObject sodaPrefab;

    protected virtual void OnEnable() {
        machine.InteractableObjectUsed += InteractableObjectUsed;
    }

    void InteractableObjectUsed(object sender, InteractableObjectEventArgs e) {
        Debug.Log("spawn soda");
        Instantiate(sodaPrefab);
    }
}
