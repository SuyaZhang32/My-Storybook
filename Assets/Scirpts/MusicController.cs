using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public Slider Slider;

    private void Start()
    {
        Slider = this.GetComponent<Slider>();
        Slider.value = DataSounds.sound;
    }

    private void Update()
    {
        DataSounds.sound = Slider.value;
    }
}
