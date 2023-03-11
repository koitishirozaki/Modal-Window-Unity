using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nankink.UI
{
    public class ModalWindowDemonstration : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                OpenModalWindow();
        }

        public void OpenModalWindow()
        {
            ModalWindow.SetAndDisplay(title: "All buttons dialog",
                                      message: "Choose one of the options below and a number will be displayed in the console!",
                                      confirmText: "Choose me!",
                                      confirmAction: Option1,
                                      declineText: "It's a me!",
                                      declineAction: Option2,
                                      alternateText: "No, it's me!",
                                      alternateAction: Option3
            );
        }

        public void OpenModalWindowNoTitle()
        {
            ModalWindow.SetAndDisplay(title: "2 buttons dialog", 
                                      message: "Here we have 2 buttons example", 
                                      confirmText: "Option 1", 
                                      confirmAction: Option1, 
                                      declineText: "Option 2", 
                                      declineAction: Option2
            );
        }

        public void OpenModalWindowNoMessage()
        {
            ModalWindow.SetAndDisplay(title: "No message, only 1 button", 
                                      confirmText: "Option 1", 
                                      confirmAction: Option1);
        }

        public void OpenModalWindowNoButton()
        {
            ModalWindow.SetAndDisplay(title: "No option", 
                                      message: "This is a modal window with no option, just a title and a message");
        }

        private void Option1()
        {
            Debug.Log("1");
        }
        private void Option2()
        {
            Debug.Log("2");
        }
        private void Option3()
        {
            Debug.Log("3");
        }

    }
}