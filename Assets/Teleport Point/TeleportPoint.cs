using UnityEngine;

public class TeleportPoint : MonoBehaviour
{
    public AudioSource teleportAudio;  // Variable para el audio de teletransporte

    public void Teleport()
    {
        TeleportManager.Instance.Teleport(transform.position);
    }
    
    public void OnPointerClick()
    {
        // Reproducir el audio antes de teletransportarse
        if (teleportAudio != null)
        {
            teleportAudio.Play();
        }
        
        Teleport();
    }
}

