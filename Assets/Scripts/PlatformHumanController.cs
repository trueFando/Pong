using UnityEngine;

public class PlatformHumanController : PlatformController
{
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Move(mainCam.ScreenToViewportPoint(Input.mousePosition).x > 0.5f);
        }
    }
}
