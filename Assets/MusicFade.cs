using UnityEngine;

public class MusicFade : MonoBehaviour
{
    [SerializeField] private Transform player;  // Player reference
    [SerializeField] private Transform templePoint; // The temple (end point)
    [SerializeField] private float startX = 0f; // Manually set player's start X position
    [SerializeField] private float templeX = 100f; // Manually set temple's X position
    [SerializeField] private AudioSource backgroundMusic;  // Music source

    private float initialVolume;

    private void Start()
    {
        if (backgroundMusic != null)
        {
            initialVolume = backgroundMusic.volume;
            backgroundMusic.Play();
        }
    }

    private void Update()
    {
        if (backgroundMusic != null && player != null)
        {
            float totalDistance = templeX - startX; // Distance between start and temple
            float playerProgress = Mathf.Clamp((player.position.x - startX) / totalDistance, 0f, 1f);
            backgroundMusic.volume = Mathf.Lerp(initialVolume, 0f, playerProgress);
        }
    }
}

