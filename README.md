# electron-vite-react

[![awesome-vite](https://awesome.re/mentioned-badge.svg)](https://github.com/vitejs/awesome-vite)
![GitHub stars](https://img.shields.io/github/stars/caoxiemeihao/vite-react-electron?color=fa6470)
![GitHub issues](https://img.shields.io/github/issues/caoxiemeihao/vite-react-electron?color=d8b22d)
![GitHub license](https://img.shields.io/github/license/caoxiemeihao/vite-react-electron)
[![Required Node.JS >= 14.18.0 || >=16.0.0](https://img.shields.io/static/v1?label=node&message=14.18.0%20||%20%3E=16.0.0&logo=node.js&color=3f893e)](https://nodejs.org/about/releases)

English | [įŽäŊä¸­æ](README.zh-CN.md)

## đ Overview

đĻ Ready out of the box  
đ¯ Based on the official [template-react-ts](https://github.com/vitejs/vite/tree/main/packages/create-vite/template-react-ts), project structure will be familiar to you  
đą Easily extendable and customizable  
đĒ Supports Node.js API in the renderer process  
đŠ Supports C/C++ native addons  
đ Debugger configuration included  
đĨ Easy to implement multiple windows  

## đĢ Quick start

```sh
npm create electron-vite
```

![electron-vite-react.gif](/public/electron-vite-react.gif)

## đ Debug

![electron-vite-react-debug.gif](/public/electron-vite-react-debug.gif)

## đ Directory structure

Familiar React application structure, just with `electron` folder on the top :wink:  
*Files in this folder will be separated from your React application and built into `dist-electron`*  

```tree
âââ electron                                 Electron-related code
â   âââ main                                 Main-process source code
â   âââ preload                              Preload-scripts source code
â
âââ release                                  Generated after production build, contains executables
â   âââ {version}
â       âââ {os}-{os_arch}                   Contains unpacked application executable
â       âââ {app_name}_{version}.{ext}       Installer for the application
â
âââ public                                   Static assets
âââ src                                      Renderer source code, your React application
```
