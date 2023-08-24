cls

REM usaremos variables

SET /P ficheros=Indique la extension incluyendo punto:
pause
echo %ficheros%
dir c:\CarlosBoni\*%ficheros% /s
pause
exit

