using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.XR.Interaction.Toolkit;

public class AppManager : MonoBehaviour
{
    bool toggleBool;
    [SerializeField] TextMeshProUGUI normalText, sliderValueText;
    [SerializeField] Button _button;
    [SerializeField] Slider _slider;


    void Start()
    {
        _button.onClick.AddListener(ToggleText);
        _slider.onValueChanged.AddListener(SliderValue);
        grabbableObjects = FindObjectsOfType<GrabableObjects>();
    }

    private void SliderValue(float arg0)
    {
        sliderValueText.text = _slider.value.ToString();
    }

    private void ToggleText()
    {
        toggleBool = !toggleBool;
        normalText.gameObject.SetActive(toggleBool);
    }

    public GrabableObjects[] grabbableObjects;

    public void ResetGrabbableObjects()
    {
        // Reset the position of each XR grabbable object to its initial position
        foreach (var grabbable in grabbableObjects)
        {
            if (grabbable != null)
            {
                // You may want to store the initial position of each object
                // and reset it to that position here
                Rigidbody RGB = grabbable.GetComponent<Rigidbody>();
                RGB.isKinematic = true;
                grabbable.transform.position = grabbable.initialPosition;
                grabbable.transform.rotation = grabbable.initialRotation;
                RGB.isKinematic = false;
            }
        }
    }
}
