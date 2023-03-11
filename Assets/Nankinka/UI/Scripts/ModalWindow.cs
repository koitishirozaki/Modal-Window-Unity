using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

namespace Nankink.UI
{
    public static class ModalWindow
    {
        const string defaultText_ConfirmationButton = "OK";
        static ModalWindowReference window;

        public static void SetAndDisplay(string title = null,
                                         string message = null,
                                         string confirmText = null,
                                         UnityAction confirmAction = null,
                                         string declineText = null,
                                         UnityAction declineAction = null,
                                         string alternateText = null,
                                         UnityAction alternateAction = null)
        {
            if (window == null)
            {
                window = GameObject.FindObjectOfType<ModalWindowReference>();
            }
            // Check if window is already on
            if (window.IsOpen)
            {
                Debug.LogError("Modal window is already open! Check if you are calling this method more than once");
                return;
            }

            SetTitleMessage(window, title: title, message: message);

            // Buttons
            window.confirmBtn.gameObject.SetActive(true);
            if (confirmText != null)
            {
                window.confirmBtn_text.text = confirmText;
            }
            else
            {
                window.confirmBtn_text.text = defaultText_ConfirmationButton;
            }
            if (confirmAction != null)
            {
                window.confirmBtn.onClick.AddListener(delegate
                {
                    confirmAction();
                    window.Close();
                });
            }
            else
            {
                window.confirmBtn.onClick.AddListener(delegate { window.Close(); });
            }
            SetButton(window, window.declineBtn, window.declineBtn_text, text: declineText, action: declineAction);
            SetButton(window, window.alternateBtn, window.alternateBtn_text, text: alternateText, action: alternateAction);

            window.Open();
        }

        static void SetTitleMessage(ModalWindowReference window, string title = null, string message = null)
        {
            if (title == null)
            {
                window.title.transform.parent.gameObject.SetActive(false);
            }
            else
            {
                window.title.transform.parent.gameObject.SetActive(true);
                window.title.text = title;
            }

            if (message == null)
            {
                window.message.transform.parent.gameObject.SetActive(false);
            }
            else
            {
                window.message.transform.parent.gameObject.SetActive(true);
                window.message.text = message;
            }
        }
        static void SetButton(ModalWindowReference window, Button btn, TextMeshProUGUI btnText, string text = null, UnityAction action = null)
        {
            if (action != null)
            {
                btnText.text = text;
                btn.gameObject.SetActive(true);
                btn.onClick.AddListener(delegate
                {
                    action();
                    window.Close();
                });
            }
            else
            {
                btn.gameObject.SetActive(false);
            }
        }

    }
}
