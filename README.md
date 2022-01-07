<p align="center">
  <img src="https://user-images.githubusercontent.com/46754519/148564799-c51ceb58-297b-4b29-a9b8-889879e97eee.png" Width=128 Height=128/>
</p>
<h1 align="center">WatermarkedTextBox</h1>
TextBox control with a customized watermark. 

## How to install
1. Download and install it from NuGet package manager to your project. Also you can use console 
```
Install-Package RudMike.WatermarkedTextBox.WinForms -Version 1.0.0
```
2. After installing the control must be shown in separate tab of your toolbox. If it doesn't, try re-open the solution. Also make sure that automatically populate toolbox is set on true.

![Screenshot 2022-01-07 174209](https://user-images.githubusercontent.com/46754519/148566903-739ec9b6-e226-4d6f-8634-43406f1b2ec1.png)

## Using
You can use the control type a usual type and in design mode.

In design mode this control has sepatare tab "Watermark" in the control properties and events windows.

## Properties
- UsePrimaryFont
- WatermarkFont
- WatermarkForeColor
- WatermarkText
- WatermarkTextAlign

## Events
- UsePrimaryFontChanged
- WatermarkFontChanged
- WatermarkForeColorChanged
- WatermarkTextAlignChanged
- WatermarkTextChanged
