REM y si queremos que se guarden en un fichero en lugar de verlo por pantalla:
C:
cd \
dir *.mp4 *.avi /s >C:\CarlosBoni\Sistemas\listados\multimedia.txt

REM y luego puedo ver el contenido de ese fichero, con windows, o con:
type C:\CarlosBoni\Sistemas\listados\multimedia.txt

REM buscaremos solo las líneas que contienen nombres de directorios de ese fichero.
REM FIND "<DIR>" < C:\CarlosBoni\ficheroszip.txt >C:\CarlosBoni\directorioszip.txt




