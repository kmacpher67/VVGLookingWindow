# VVGLookingWindow
Looking in on Vincent or Lurker van gogh for Ingenuity fest Cleveland, OH 2015. 

if you ALREADY DONE THE EMGUCV mono-complete there is no reason to do it again. 
Install EMGUCV into a working directory. 
Follow EMGUCV installation steps from here: 
http://www.emgu.com/wiki/index.php/Download_And_Installation#Raspbian_.28Raspberry_Pi_2.29
To install mono

```
sudo apt-get update 
sudo apt-get upgrade 
sudo apt-get install cmake
sudo apt-get install mono-complete
sudo apt-get install git
git clone git://git.code.sf.net/p/emgucv/code emgucv 
cd emgucv
git submodule update --init --recursive
cd platforms/raspian/
sudo ./apt_install_dependency
./cmake_configure
cd ../..
sudo make 
sudo chown -R pi:pi * 
```
The mono-complete takes about 5 minutes. 
The clone of the emgucv down to local system on decent Internet is about 5-10 minutes. 
The git submodule is a good 30-60 minutes. Break time to go grab a steak. 
the make step is suprisingly fast like 10 minutes. 

after you get mono & emgucv running the tests helloworld stuff and examples. then try you luck at

```
cd emgucv
git clone https://github.com/kmacpher67/VVGLookingWindow.git VVGLookingWindow
```


After you get it installed local. 
Use the startx gui to run
Menu - Programming - MonoDevelop 
This will run a Visual Studio like application, use the File - Open - scroll and open the pla10.sln solution (or whatever version VS2010 version is in the directory) 
