using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapzoneTest : MonoBehaviour
{
    public static void SnapzoneEnterTrigger()
    {
        Debug.Log("Snapzone triggered");
    }

    public static void SnapzoneExitTrigger()
    {
        Debug.Log("Exited from snapzone");
    }
}
