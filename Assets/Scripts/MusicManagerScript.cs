﻿/* Copyright (C) 2017 Francesco Sapio - All Rights Reserved
 * The license use of this code and/or any portion is restricted to the 
 * the project DELTA CORE, subject to the condition that this
 * copyright notice shall remain.
 *  
 * Modification, distribution, reproduction or sale of this 
 * code for purposes outside of the license agreement is 
 * strictly forbidden.
 * 
 * NOTICE:  All information, intellectual and technical
 * concepts contained herein are, and remain, the property of Francesco Sapio.
 *
 * Attribution is required.
 * Please write to: contact@francescosapio.com
 */

using UnityEngine;
using System.Collections;

public class MusicManagerScript : MonoBehaviour {

    public static AudioSource c_audioSource;

    private void Start() {
        if (c_audioSource != null)
            GameObject.Destroy(this);
        else {
            c_audioSource = gameObject.GetComponent<AudioSource>();
            GameObject.DontDestroyOnLoad(this);
            c_audioSource.Play();
        }
    }


    void Update() {
        if (Input.GetKey(KeyCode.Escape) && Input.GetKey(KeyCode.LeftControl)) {
            Application.Quit();
        }
    }
}
