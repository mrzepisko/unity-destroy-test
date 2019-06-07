using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroySample2Test : MonoBehaviour {
    private static DontDestroySample2Test instance;

    void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(gameObject);
            Debug.LogWarning("Already destroyed, but still working!");
            return;
        }
        Debug.Log("[DontDestroySample2Test] Calling DontDestroyOnLoad");
        DontDestroyOnLoad(gameObject);
    }
}