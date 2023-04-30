# Analysis of vibration signal
This application implements a vibration alarm and implements a bearing failure prediction based on data from another failure.

## A file describing the application development process and all the mathematical formulas used.
[App_viration_signal.docx](https://github.com/EclipsePLZ/Vibration_Analysis/files/11361456/_.docx)

## Load data
The first step is to load the data from the excel file into the application.

![Load_data](https://user-images.githubusercontent.com/84061271/235356660-73f7c77e-1089-4c39-a50b-47ef4f02e28a.png)

## Calculation of bearing reliability by vibration signal
The second step is to calculate the reliability of the bearing, based on its vibration signal. Reliability coefficients are assigned to each value of the vibration signal.

![Step_2](https://user-images.githubusercontent.com/84061271/235356712-af148261-a41d-426d-8d57-8ecf1b2c5889.png)

## Finding the cutoff in the second accident
The third step is the best place from which to consider the second crash. This location is found by calculating the Pearson coefficient.

![Step_3](https://user-images.githubusercontent.com/84061271/235356801-b98ed58b-ce0a-45c1-8314-3e22953a20eb.png)

## Finding a polynomial to represent the second accident through the reference accident
The fourth step is to find the best degree of the polynomial and express the second accident through the first one using the constructed n-degree equation.

![Step_4](https://user-images.githubusercontent.com/84061271/235357106-99d46455-ceb8-4fce-87a5-f9b151404a51.png)

## Comparison of reliability coefficients for the theoretical accident
In the last step, reliability coefficients for real values of vibration and those calculated theoretically with the help of the equation found are derived.

![Step_5](https://user-images.githubusercontent.com/84061271/235357316-56de7214-4236-4c00-936e-4e07b15380ab.png)
