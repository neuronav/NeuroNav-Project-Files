# NeuroNav-Project-Files

**SHORT SUMMARY**

We are a team of University of Washington Bioengineering graduate students trying to streamline frameless stereotaxy in neurosurgical navigation. Using Microsoft HoloLens and augmented reality we have created a surgical tool to be used intra-operatively for neurosurgical navigation which can overlay holograms of 3D patient specific medical images. This in short gives you X-Ray Vision seeing a patients MRI or CT live during surgery. We are taking 3D medical images and putting them into 3D space removing the need for extra screens and navigation tools within the operating room streamlining stereotaxy during surgery. 

Like a standard PACS radiological software you can view the MRI slice by slice in the sagittal plane. Using ray tracing techniques we managed to show volume within the 3D brain hologram.


**BACKGROUND**

Using augmented reality, NeuroNav overlays patient specific preoperative medical imaging onto a patient’s head in real time for needle guided tumor resection and tumor biopsy. Current framed and frameless stereotaxy display 3D medical imaging modalities on 2D screens outside of the surgical making image manipulation and surgery visualization difficult. We are improving stereotactic procedures by bringing 3D medical images into 3D space. We are freeing surgeons from 2D screens by using FDA approved Microsoft HoloLens and our novel algorithms to place multiple imaging modalities inside the surgical field thus improving surgical workflow. NeuroNav is the next step for medical imaging.

**NEED STATEMENT**

Neurosurgeons and their clinical team need a more efficient way to perform frameless stereotaxy during cranial tumor resection and biopsy procedures in order to improve real-time intraoperative 3D medical image visualization.


**What is Stereotaxy and why do we care?**

Stereotaxy is a way to navigate the brain to target a tumor for example for resection or biopsy. It's like google earth for the brain. It shows you where you are and your area of interest within the brain. Framed stereotaxy is the more precise method. The patient is fixed to the table so their head cannot move and the measurements are done with error originating from the fixed frame. This system can get in the way during surgery although its accuracy is incredible at 1 millimeter to 0.6 millimeters. Frameless stereotaxy the patients head no longer needs to be fixed to the table. It uses fiducial markers to track where it is in space. It is not as accurate as framed stereotaxy but it is better visualization and does not get in the way during surgery.


**SOLUTION**

Using HoloLens Augmented Reality Headset we have created a frameless stereotactic system that can overlay holograms of medical images onto a patient for neurosurgical navigation to target a tumor during surgery without the need for extra navigational tools or extra screens cluttering the operating room.

**OUR WORKFLOW**

3D Slicer - Program that takes medical images and creates an obj or stl model from them. This is how we made our MRI and CT OBJ files. 
Available [here](https://www.slicer.org/)

Blender - Smooths out the stl or obj files for easie import into Unity

Unity - Game developer software used to create the application itself. Using the Windows Mixed Reality Toolkit you can create a HoloLens application. Unity can also connect to Vuforia within the application for image tracking

Vuforia - Image tracking software. We used this to track out QR code placed on the patients head to track 



**What's in this GitHub Repo?**

Inside this GitHub Repo are all the assets for making this system in Unity. All 3D models and scripts for ray tracing are within this Repo. 

**What else do I need?**

You need to install the [Windows Mixed Reality Tollkit](https://microsoft.github.io/MixedRealityToolkit-Unity/Documentation/GettingStartedWithTheMRTK.html) to run this system on HoloLens and make sure you install MRTK Foundation, Extensions and Tools.

**Basic Intructions**

1. Download Windows Mixed Reality Toolkit
2. Download NeuroNav's Repo
3. Import these as packages into Unity
4. Run ray tracing code ray tracing algorithm courtesy of @przemyslawzaworski with this ray tracing code
4. Enable [Vuforia](https://developer.vuforia.com/vui/auth/login)
    a. Go to and create an account, add an image and download the package to be imported to Unity.
    b. For more help with image tracking I used [this tutorial](https://youtu.be/MtiUx_szKbI)
    c. Change all the settings to make Vuforia run on HoloLens. [Here's a tutorial for that](https://library.vuforia.com/content/vuforia-library/en/articles/Solution/Working-with-the-HoloLens-sample-in-Unity.html)
5. Make the build
6. Open build in Visual Studios
7. Profit
