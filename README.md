<<<<<<< HEAD
# 🎶 Build Your Concert 🎶

## Overview
"Build Your Concert" is a **virtual reality (VR) experience** designed for individuals who are unable to attend live concerts due to health risks or accessibility challenges. This project simulates the concert environment using **Unity** and aims to provide users with the joy of live music from the comfort of their homes. Whether it’s for individuals affected by **photosensitive epilepsy**, or those facing **mobility issues**, this VR concert ensures an inclusive entertainment experience for everyone!

![Concert Simulation](https://img.shields.io/badge/Unity-100000?style=for-the-badge&logo=unity&logoColor=white)

---

## 🎯 Project Goals
- Create an immersive concert environment to simulate live music performances.
- Cater to users with **health concerns** or **mobility challenges**.
- Use **VR technology** to provide a customizable and comfortable concert experience.
- Introduce inclusivity for those affected by flashing lights and large crowds, based on studies linking strobe lights with epileptic seizures.

---

## ⚙️ Development Process
The project was developed using **Unity** and involved:
- **Environment Creation**: Designing a virtual concert venue with stages, lights, a DJ setup, and high-definition characters.
- **Lighting & Animation**: Custom lighting effects using Unity’s **spotlights** and **C# scripting** to animate lights in sync with music.
- **Audio Integration**: Mixing real concert audio and crowd sounds using **Audacity** to give an authentic live performance feel.
- **User Interface**: Developing a main menu and in-game menu for selecting music genres (Afrobeat, Pop, Rock, R&B) and toggling lighting options.

---

## 💻 Technology Stack
- **Unity**: Game engine used to develop the entire concert environment.
- **C#**: Scripted custom animations and game logic for light and audio management.
- **Audacity**: Audio editing tool used to combine concert and crowd sounds.
- **Oculus Quest 2**: Hardware used for VR testing.

---

## 🎮 Features
- **Concert Environment**: Virtual stage, lighting system, DJ setup, and crowd characters.
- **Music Genres**: Users can select from **Afrobeat**, **Pop**, **Rock**, or **R&B** genres.
- **Light Control**: Toggle stage lights on and off to cater to users who are sensitive to bright lights.
- **Audio Integration**: Real concert audio tracks are synced with the lighting and stage setup.

---

## 🛠️ How It Works
1. **Main Menu**: Start the concert or exit the game.
2. **In-Game Menu**: Choose a music genre and control the stage lights.
3. **VR Interaction**: Look around the concert venue, observe characters dancing, and enjoy a personalized concert experience.

---

## 🔗 Project Links
- **GitHub Repository**: [Build Your Concert](https://github.com/kzeina/Build-A-Concert)
- **Google Drive with Project Files**: [Download Project Files](https://drive.google.com/file/d/1_-2CH1DCkxACLBL3vqTwfMOyuBEgFM3a/view?usp=drive_link)

---

## 📜 Future Enhancements
- Expand the number of **music genres**.
- Introduce **multiplayer** functionality for shared concert experiences.
- Offer different **concert venues** like Madison Square Garden.

---

## 📚 References
- [Stroboscopic Light Effects](https://www.ncbi.nlm.nih.gov/pmc/articles/PMC6585837/)
- [Mixamo - 3D Characters & Animations](https://www.mixamo.com/#/)
- [Audacity - Audio Editor](https://www.audacityteam.org/)
=======

## Instructions/Run Through

When you first run the program, you are presented with a welcome text as well as two buttons, one to start the concert, which takes you to the concert scene, and one to exit, which quits the program.

In the concert scene, you are presented with another menu. With the choice of playing music from four different genres: Afrobeat; Rock; Pop; R&B. As well as a toggle lights option in case you want to turn the lights on or off to cater to your needs. You also have the option of going back to the main menu to exit the program altogether. 
If while in a concert scene, you decide you want to change genres, all you need is to click the button of the genre you want from the menu!

## Problems & Challenges
During the implementation process, we faced two major issues that posed a challenge to us in the smooth running and functionality of our simulation. The first of which was controlling the animation of the lights accurately. We had a functioning code that operating the animation of the spotlight that was based on the stage, however we faced a challenge assigning the right positions to the light as well as controlling the speed of the light, which made the light move around too quickly. We were able to fix this issue by combining the hand animation features of Unity along with our code to correct the speed and the positioning. We also observed during file transfers from one PC to the other, or from our drive to the Lab PC, we would lose some elements of our scene especially some of the animated lights, which we had to reimplement.
Secondly, after we implemented the Main Menu and the Concert Menu with the buttons, we built the project onto the Oculus and observed that our buttons were not functioning. When the user tried to use the Poke interactive feature on the button, the hand icon would go straight through the button and would not interact with it. We reassessed our code as well as our implementation of the buttons and if we assigned the scripts accurately to the buttons, we also re implemented the VR Interaction using the Oculus website tutorial. However, the issue pertained and we were finally able to fix this by duplicating the template that was provided, and copy all the assets from our scene onto that template scene and reimplemented the buttons and the buttons started to function.








>>>>>>> 71781b648aaf8bee90b7ce43840e41c35363c598
