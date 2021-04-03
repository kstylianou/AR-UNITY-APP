using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GAME_HANDLE : DefaultTrackableEventHandler
{
    public UnityEvent onFound;
    public UnityEvent onLost;

    protected override void OnTrackingFound()
    {
        // if you also want the default behaviour in this
        // (enables Renderers, Colliders and Canvas)
        // base.OnTrackingFound();
        base.OnTrackingFound();
        SceneManager.LoadScene("Main", LoadSceneMode.Additive);
        onFound.Invoke();
    }

    protected override void OnTrackingLost()
    {
        // if you also want the default behaviour in this
        // (Disables Renderers, Colliders and Canvas)
        // base.OnTrackingLost();

        onLost.Invoke();
    }
}