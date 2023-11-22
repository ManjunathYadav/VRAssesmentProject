using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public AudioClip bounceSound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.clip = bounceSound;
    }

    private void OnCollisionExit(Collision other)
    {
        audioSource.PlayOneShot(bounceSound);
    }
}