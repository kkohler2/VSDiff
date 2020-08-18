# VSDiff
Utility to select two files to compare using Visual Studio's /diff command line option.

To use: download source, update app.config (see below) to set correct path to Visual Studio, build it.  Add a link to start menu or start screen, then just click the link.  Select your files and Visual Studio will be launched to do a diff.

<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
    </startup>
  <appSettings>
    <add key="DevStudio" value="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.exe"/>
  </appSettings>
</configuration>
