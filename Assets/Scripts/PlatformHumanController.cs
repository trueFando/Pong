using UnityEngine;

public class PlatformHumanController : PlatformController
{
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // move right if mouse pointer is on the left side of the screen, else left
            Move(mainCam.ScreenToViewportPoint(Input.mousePosition).x > 0.5f);
        }
    }
}
