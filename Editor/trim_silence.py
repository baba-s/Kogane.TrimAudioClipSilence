import librosa
import soundfile
import sys

source      = sys.argv[1]
destination = sys.argv[2]
top_db      = sys.argv[3]
y, sr       = librosa.load(source, sr=None, mono=False)
yt, index   = librosa.effects.trim(y, top_db=int(top_db))

soundfile.write(file=destination, data=yt.T, samplerate=sr)