using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundMusic : MonoBehaviour {
    public AudioSource MusicSource;
    public Toggle MusicToggle;
    public Slider MusicSlider;

    void Start() {
        MusicSource.Play(0);
        MusicToggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(MusicToggle);
        });

        MusicSlider.onValueChanged.AddListener(delegate { 
            ValueChangeCheck(); 
        });
    }

    void ToggleValueChanged(Toggle change) {
        if (MusicToggle.isOn) {
            MusicSource.UnPause();
        } else {
            MusicSource.Pause();
        }
    }

    void ValueChangeCheck() {
        MusicSource.volume = MusicSlider.value;
    }
}