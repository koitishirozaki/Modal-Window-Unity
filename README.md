# Modal Window for Unity #

This is a simple Modal Window project which you can call a modal window from anywhere.
With this asset, you can:
- Display Title, a message and up to 3 options.
You can also hide title or/and the message, giving only the options.

## Quick Setup ##
Just drag the CANVAS_ModalWindow prefab contained in the Prefab folder to your scene and you will be ready to go. It's already in its own canvas, so don't put inside your canvas.
To use it, call ModalWindow.SetAndDisplay() where you need. You adjust what will be exhibited inside the parameters
Such as:
```cs
ModalWindow.SetAndDisplay(title: "Hi",
				  message: "Hello World",
				  confirmText: "Make it say hi!",
				  confirmAction: AttachConfirmButton);
```
This example shows a dialog containing a title, message and one button.

Check the ModalWindowDemonstration for more options and ways you can use this asset.

### What is this repository for? ###

I created just for me because I've created a lot of modal windows and every time is different lol. 
It's kinda janky tbh, but it was okay for my needs at the time. There's a BUNCH of stuff that could improve or made different but whatever, maybe someday.

### Observations ###

- It requires TextMeshPro. You will be prompted to import it if you don't have in the project.
- I used Unity's animation solution for the fading so there's the least dependency possible for a package, but you could change to DOTween's DOFade or something alike.

### Known Limitations ###
- You can't call another modal window from the options since the architecture doesn't allow (I told you it was janky)