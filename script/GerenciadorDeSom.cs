using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDeSom : MonoBehaviour
{
    [SerializeField]
    private AudioClip explosion;

    private List<AudioSource> audios;

    private void Awake()
    {
        audios = new List<AudioSource>();
        if(explosion != null)
        {

            var ac = gameObject.AddComponent<AudioSource>();
            ac.clip = explosion;
            ac.name = "Explosion";
            audios.Add(ac);
        }
    }
    public void TocaAudio(string nome)
    {
        foreach(var audio in audios)
        {
            if (audio.name.Equals(name))
            {
                audio.Play();
                break;
            }
        }
    }
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
