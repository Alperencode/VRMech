using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedScript : MonoBehaviour
{
    
    Material material;
    new Renderer renderer;
    Color emissionColor;
    public bool PowerCheck;
    public bool LedCheck;
    bool canLedBeOn;

    void Start()
    {

        renderer = GetComponent<Renderer>();
        material = renderer.material;
        emissionColor = Color.red;
        // StartCoroutine(Toggle()); to activate Toggle func
        
    }

    private void FixedUpdate()
    {

        canLedBeOn = ((PowerCheck == true) && (LedCheck == true));
        Activate(canLedBeOn);

    }

    /* To make led turn on and off with 1 sec delay
    IEnumerator Toggle()
    {
        bool toggle = false;
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Activate(toggle, Random.Range(0.5f, 2f));
            toggle = !toggle;
        }
    }
    */

    public void Activate(bool on, float intensity = 1f)
    {
        if (on)
        {

            // Enables emission for the material, and make the material use
            // realtime emission.
            material.EnableKeyword("_EMISSION");
            material.globalIlluminationFlags = MaterialGlobalIlluminationFlags.RealtimeEmissive;

            // Update the emission color and intensity of the material.
            material.SetColor("_EmissionColor", emissionColor * intensity);

            // Makes the renderer update the emission and albedo maps of our material.
            RendererExtensions.UpdateGIMaterials(renderer);

            // Inform Unity's GI system to recalculate GI based on the new emission map.
            DynamicGI.SetEmissive(renderer, emissionColor * intensity);
            DynamicGI.UpdateEnvironment();

        }
        else
        {

            material.DisableKeyword("_EMISSION");
            material.globalIlluminationFlags = MaterialGlobalIlluminationFlags.EmissiveIsBlack;

            material.SetColor("_EmissionColor", Color.black);
            RendererExtensions.UpdateGIMaterials(renderer);

            DynamicGI.SetEmissive(renderer, Color.black);
            DynamicGI.UpdateEnvironment();

        }
    }
}
