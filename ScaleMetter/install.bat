sc create ScaleMetter binPath= "%~dp0ScaleMetter.exe"
sc failure ScaleMetter actions= restart/60000/restart/60000/restart/60000 reset= 86400
sc start ScaleMetter
sc config ScaleMetter start=auto