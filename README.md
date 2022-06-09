# Macro-Deck-Philips-Hue-Plugin
![GitHub](https://img.shields.io/github/license/RecklessBoon/Macro-Deck-Philips-Hue-Plugin)

A Macro Deck plugin to manager and interact with Philips Hue light bridges.

If you like my work and want to support/encourage me in making more plugins, you certainly can do so on Ko-Fi.

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/Z8Z37FRBM)

## Features

### Variables
This plugin updates the following variables for use anywhere variables are
allowed in Macro Deck 2

| Variable Name | Description |
| ------------- | :---------- |
|               |             |

> **NOTE** I didn't put any variables in for this at the moment. If you would like to suggest
a variable for me to add, please use the Issues tab and submit a new feature-request.

### Actions
This plugin adds the following actions

| Action       | Description                                                       |
| ---------    | :---------------------------------------------------------------- |
| Set Scene    | Sets an existing group to an existing scene                       |
| Update Light | Updates one or more lights to a custom state                      |
| Adjust Light | Adjusts onr or more lights relative to their current states       |

## Installation
Download/Install it directly in Macro Deck from the package manager.

## Configuration

**Visual learner?** Here is my video tutorial for setting up this plugin in Macro 
Deck 2
<br/>
[_In Progress_](https://www.youtube.com/channel/UCi8N73K0K49Qgclug0Zb5Pg)

### Connecting the Philips Hue Bridge
1. Open Macro Deck 2 application on your computer
2. Switch to the plugin manager view and locate the Philips Hue plugin (install if 
   necessary)
3. Click the "Configure" button
4. Wait for your bridge to appear in the list of discovered bridges
   - **Note** It may take up to 30 seconds for the bridge to appear
5. Click the "Connect..." button to the right of the correct bridge
6. **WITHIN 30 SECONDS** press the connection button on the top of your bridge

If it worked, then you should see "Connected" in the button to the right.

## Addendum

### Not a Standalone App
<img align="right" height="96px" src="https://macrodeck.org/images/macro_deck_2_community_plugin.png" />

This is a plugin for [Macro Deck 2](https://github.com/SuchByte/Macro-Deck), it does **NOT** function as a standalone app

### Third Party Licenses / Thank you

This plugin is built upon the shoulders of giants. Here are their licenses:

- [Newtonsoft.Json](https://www.newtonsoft.com/json)
- [Q42 Hue API](https://www.nuget.org/packages/Q42.HueApi)
- [Q42 Hue API Color Converters](https://www.nuget.org/packages/Q42.HueApi.ColorConverters/)