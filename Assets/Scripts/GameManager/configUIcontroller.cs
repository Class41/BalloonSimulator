﻿/*configUIcontroller.cs
 * 11.14.2019
 * Balloon Physics Simulator
 * Author: Team NoName
 * Description: This script controls which UI components are enabled or
 * disabled. It will obtain boolean values from the config object and
 * set active game objects based on it.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class configUIcontroller : MonoBehaviour
{
    public JSONconfig config;
    private bool colorWheel;
    private bool radiusSlider;
    private bool windSlider;
    private bool inflateDeflateButton;
    private bool graph;
    private bool dataBox;
    public GameObject colorPanel;
    public GameObject radiusPanel;
    public GameObject windPanel;
    public GameObject radiusWindPanel;
    public GameObject sliderPanel;
    public GameObject inflateDeflatePanel;
    public GameObject graphPanel;
    public GameObject dataPanel;
    public GameObject leftPanel;
    public GameObject rightPanel;
    //public GameObject exportBtn;

    // Start is called before the first frame update
    void Start()
    {
        colorPanel = GameObject.Find("COLOR_PICKER");
        radiusPanel = GameObject.Find("PANEL_RADIUS");
        windPanel = GameObject.Find("PANEL_WIND");
        radiusWindPanel = GameObject.Find("CPANEL_TOP_R");
        sliderPanel = GameObject.Find("CPANEL_BOTTOM_R");
        inflateDeflatePanel = GameObject.Find("CPANEL_INFLATE_DEFLATE_BUTTON");
        graphPanel = GameObject.Find("CPANEL_BOTTOM_L");
        dataPanel = GameObject.Find("CPANEL_TOP_L");
        leftPanel = GameObject.Find("CPANEL_LEFT");
        rightPanel = GameObject.Find("CPANEL_RIGHT");

        colorWheel = config.loadedConfig.colorWheel;
        radiusSlider = config.loadedConfig.radiusSlider;
        windSlider = config.loadedConfig.windSlider;
        inflateDeflateButton = config.loadedConfig.inflateDeflateButton;
        graph = config.loadedConfig.graph;
        dataBox = config.loadedConfig.dataBox;

        if (colorWheel == true)
        {
            colorPanel.SetActive(true);
        }
        else
        {
            colorPanel.SetActive(false);
        }

        // right panel UI control
        if (radiusSlider == true && windSlider == true)
        {
            radiusPanel.SetActive(true);
            windPanel.SetActive(false);
            radiusWindPanel.SetActive(true);
        }
        else if (radiusSlider == true && windSlider == false)
        {
            radiusPanel.SetActive(true);
            radiusWindPanel.SetActive(false);
            windPanel.SetActive(false);
        } 
        else if (radiusSlider == false && windSlider == true)
        {
            radiusPanel.SetActive(false);
            windPanel.SetActive(true);
            radiusWindPanel.SetActive(false);
        } 
        else if (radiusSlider == false && windSlider == false)
        {
            rightPanel.SetActive(false);
        }

        if (inflateDeflateButton == true)
        {
            inflateDeflatePanel.SetActive(true);
        }
        else
        {
            inflateDeflatePanel.SetActive(false);
        }

        // left panel UI control
        if (graph == true)
        {
            graphPanel.SetActive(true);
        } else
        {
            graphPanel.SetActive(false);
        }

        if (dataBox == true)
        {
            dataPanel.SetActive(true);
        }
        else
        {
            dataPanel.SetActive(false);
        }

        if (graph == false && dataBox == false)
        {
            leftPanel.SetActive(false);
        }
       
    }
}
