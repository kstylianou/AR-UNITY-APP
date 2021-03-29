using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDefaultTrackableEventHandler : DefaultTrackableEventHandler
{

    public static int countNum = 0;

    protected override void OnTrackingFound()
    {
        if (mTrackableBehaviour)
        {
            var rendererComponents = mTrackableBehaviour.GetComponentsInChildren<Renderer>(true);
            var colliderComponents = mTrackableBehaviour.GetComponentsInChildren<Collider>(true);
            var canvasComponents = mTrackableBehaviour.GetComponentsInChildren<Canvas>(true);

            // Enable rendering:
            foreach (var component in rendererComponents)
                component.enabled = true;

            // Enable colliders:
            foreach (var component in colliderComponents)
                component.enabled = true;

            // Enable canvas':
            foreach (var component in canvasComponents)
                component.enabled = true;

            if (mTrackableBehaviour.TrackableName == "puzzle_1")
            {
                countNum++;
            }

            if (mTrackableBehaviour.TrackableName == "puzzle_2")
            {
                countNum++;
            }

            if (mTrackableBehaviour.TrackableName == "puzzle_3")
            {
                countNum++;
            }

            if (mTrackableBehaviour.TrackableName == "puzzle_4")
            {
                countNum++;
            }
        }

        if (OnTargetFound != null)
            OnTargetFound.Invoke();
    }

    protected override void OnTrackingLost()
    {
        if (mTrackableBehaviour)
        {
            var rendererComponents = mTrackableBehaviour.GetComponentsInChildren<Renderer>(true);
            var colliderComponents = mTrackableBehaviour.GetComponentsInChildren<Collider>(true);
            var canvasComponents = mTrackableBehaviour.GetComponentsInChildren<Canvas>(true);

            // Disable rendering:
            foreach (var component in rendererComponents)
                component.enabled = false;

            // Disable colliders:
            foreach (var component in colliderComponents)
                component.enabled = false;

            // Disable canvas':
            foreach (var component in canvasComponents)
                component.enabled = false;

            if (mTrackableBehaviour.TrackableName == "puzzle_1")
            {
                countNum--;
            }

            if (mTrackableBehaviour.TrackableName == "puzzle_2")
            {
                countNum--;
            }

            if (mTrackableBehaviour.TrackableName == "puzzle_3")
            {
                countNum--;
            }

            if (mTrackableBehaviour.TrackableName == "puzzle_4")
            {
                countNum--;
            }
        }

        if (OnTargetLost != null)
            OnTargetLost.Invoke();
    }
}
