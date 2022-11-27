using UnityEngine.Audio;
using UnityEngine;

// COMMENT UTILISER :
// - créer un objet AudioController
// - ajouter ce script
// - ajouter en argument la musique à jouer 

public class AudioController : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip sound;
    
    [Range(0f, 1f)]
    public float volume;
    
    [Range(0.1f, 2.5f)]
    public float pitch;

    private AudioSource source;

    void Awake(){
        gameObject.AddComponent<AudioSource>();
        source = GetComponent<AudioSource>();

        volume = 0.5f;
        pitch = 1f;
    }
    
    void Start()
    {
        source.clip = sound;
        source.volume = volume;
        source.pitch = pitch;
        PlayAndPause();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m")) {
            PlayAndPause();
        }
        source.volume = volume;
        source.pitch = pitch;
    }
    public void PlayAndPause() 
    {
        if (!source.isPlaying) { 
            source.Play();
        }
        else {
            source.Pause();
        }
    }
}
