# Build-A-Concert
## Concerts for Everyone: When Music Meets Challenges

>Many people love going to live concerts for the fun and excitement they bring. However, not everyone can join in. Some fans have health issues that make it risky to be in big crowds or around loud noises. "Build Your Concert" is a video game project that lets you enjoy a concert without having to worry about these risks. It's perfect for fans who have to be careful about their health, or for anyone who finds flashing concert lights and loud sounds too much to handle. With this game, we want to make sure everyone can have the experience of a live concert in a way that's safe and comfortable for them. It's all about bringing the joy of music to more people, using technology to make concerts accessible to everyone, everywhere.

>An article published by the US National Center for Biotechnology Information studied the effects of stroboscopic lights during EDM concerts in Amsterdam, and concluded that these lights triple the threat of epileptic seizures in susceptible individuals. 

>Additionally, there are a plethora of external factors that affect the ability of people being able to get out  of their house and attend social events with entertainment value, such as a concert. A very recent and relevant example being that of people that were confined to their homes due to the COVID-19 pandemic. A study that reflected the mental health condition of home confined young adults during the pandemic reflected a very prominent positive relationship between the lack of social interaction and deteriorating mental health and happiness, which in turn has adverse effects on the society as a whole.

>Our project aims at introducing some level of inclusivity for people that have certain challenges or difficulties in attending live concerts and enjoying the feel of being at an actual concert. We wanted to simulate the experience of being at a concert, at the comfort of your house with the tap of a button. 

## Instructions/Run Through

When you first run the program, you are presented with a welcome text as well as two buttons, one to start the concert, which takes you to the concert scene, and one to exit, which quits the program.

In the concert scene, you are presented with another menu. With the choice of playing music from four different genres: Afrobeat; Rock; Pop; R&B. As well as a toggle lights option in case you want to turn the lights on or off to cater to your needs. You also have the option of going back to the main menu to exit the program altogether. 
If while in a concert scene, you decide you want to change genres, all you need is to click the button of the genre you want from the menu!

## Problems & Challenges
During the implementation process, we faced two major issues that posed a challenge to us in the smooth running and functionality of our simulation. The first of which was controlling the animation of the lights accurately. We had a functioning code that operating the animation of the spotlight that was based on the stage, however we faced a challenge assigning the right positions to the light as well as controlling the speed of the light, which made the light move around too quickly. We were able to fix this issue by combining the hand animation features of Unity along with our code to correct the speed and the positioning. We also observed during file transfers from one PC to the other, or from our drive to the Lab PC, we would lose some elements of our scene especially some of the animated lights, which we had to reimplement.
Secondly, after we implemented the Main Menu and the Concert Menu with the buttons, we built the project onto the Oculus and observed that our buttons were not functioning. When the user tried to use the Poke interactive feature on the button, the hand icon would go straight through the button and would not interact with it. We reassessed our code as well as our implementation of the buttons and if we assigned the scripts accurately to the buttons, we also re implemented the VR Interaction using the Oculus website tutorial. However, the issue pertained and we were finally able to fix this by duplicating the template that was provided, and copy all the assets from our scene onto that template scene and reimplemented the buttons and the buttons started to function.








