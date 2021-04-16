@echo off
CD /D "%~dp0" >NUL 2>NUL
FOR /F "tokens=*" %%G IN ('DIR /B /AD /S bin') DO (
    ECHO Deleting '%%G'...
    RMDIR /S /Q "%%G"
)
FOR /F "tokens=*" %%G IN ('DIR /B /AD /S obj') DO (
    ECHO Deleting '%%G'...
    RMDIR /S /Q "%%G"
)