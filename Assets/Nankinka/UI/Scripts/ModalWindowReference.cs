using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Nankink.UI
{
    public class ModalWindowReference : MonoBehaviour
    {
        public bool IsOpen { get { return m_isOpen; } }
        private bool m_isOpen = false;

        public TextMeshProUGUI title;
        public TextMeshProUGUI message;

        public Button confirmBtn;
        public TextMeshProUGUI confirmBtn_text;
        public Button declineBtn;
        public TextMeshProUGUI declineBtn_text;
        public Button alternateBtn;
        public TextMeshProUGUI alternateBtn_text;

        [SerializeField] private Animator animator;
        [SerializeField] private CanvasGroup canvasGroup;

        internal void Open()
        {
            animator.SetBool("isOpen", true);
            m_isOpen = true;
        }
        internal void Close()
        {
            confirmBtn.onClick.RemoveAllListeners();
            declineBtn.onClick.RemoveAllListeners();
            alternateBtn.onClick.RemoveAllListeners();
            m_isOpen = false;

            StartCoroutine(CloseSubroutine());
        }
        IEnumerator CloseSubroutine()
        {
            canvasGroup.interactable = false;
            animator.SetBool("isOpen", false);
            yield return new WaitForSecondsRealtime(0.5f);
        }
    }
}
