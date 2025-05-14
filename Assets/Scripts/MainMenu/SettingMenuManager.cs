using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using UnityEditor.Rendering;

public class SettingMenuManager : MonoBehaviour
{
    public TMP_Dropdown _GraphicDropDown;
    public TMP_Dropdown _ResDropDown;
    public Toggle _FullScreenToggle;
    private Resolution [] _AllResolutions;
    private bool _IsFullScreen;
    private int _SelectedResolution;
    List<Resolution> _SelectedResolutionList = new List<Resolution>();
    public void Start()
    {
        //Resolution Setup
        _IsFullScreen = true;
        _AllResolutions = Screen.resolutions;

        List<string> _resolutionStringList = new List<string>();
        string _newRes;
        foreach(Resolution res in _AllResolutions)
        {
            _newRes = res.width.ToString() + " x " + res.height.ToString();
            if(!_resolutionStringList.Contains(_newRes))
            {
                _resolutionStringList.Add(_newRes);
                _SelectedResolutionList.Add(res);
            }
        }

        _ResDropDown.AddOptions(_resolutionStringList);

        //Graphic Setup
        // Dropdown siyahısını avtomatik doldur
        _GraphicDropDown.ClearOptions();
        _GraphicDropDown.AddOptions(new System.Collections.Generic.List<string>(QualitySettings.names));
        _GraphicDropDown.value = QualitySettings.GetQualityLevel();
        _GraphicDropDown.RefreshShownValue();

        // Eventi skriptlə əlavə et (əgər editor'dan etməmisənsə)
        _GraphicDropDown.onValueChanged.AddListener(delegate { ChangesGraphicsQuality(); });
    }

    public void ChangesGraphicsQuality()
    {
        QualitySettings.SetQualityLevel(_GraphicDropDown.value, true);
        Debug.Log("Selected quality: " + QualitySettings.names[_GraphicDropDown.value]);
    }

    public void ChageResolution()
    {
        _SelectedResolution = _ResDropDown.value;
        Screen.SetResolution(_SelectedResolutionList[_SelectedResolution].width , _SelectedResolutionList[_SelectedResolution].height , _IsFullScreen);
    }

    public void ChageFullScreen()
    {
        _IsFullScreen = _FullScreenToggle.isOn;
        Screen.SetResolution(_SelectedResolutionList[_SelectedResolution].width , _SelectedResolutionList[_SelectedResolution].height , _IsFullScreen);
    }
}

