# 2022_07_15_OMIComLayer
OMI should be a core where people add their tool and can decide to use mine if they want. For that we need an interface to connect to.

I can't code everything and should not. I want an open source project then I need a way to mod my tools. 

OMI is compose for the moment of few thing:
- Ability to receive:
  - Command Line
    - Shortcut Group
    - Shortcut
  - Boolean change state
    - Ability to switch and access boolean state from id name
  - Ability to be configured by files modification based on the extension name.
  
  
 For the moment, I don't know how the interface must be. But I need to find a way to make it simple.
 
 The idea here is that you create a Unity package that do something specific.
You copy this repository in your project to interface the communication you need to have with the project OMI.
When you have you import your package in the omi project (the communcation will already be there).
