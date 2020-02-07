static class UtilAlgumaCoisa {
    public static void ProcessaTeclas(Keys key, SpeechSynthesizer sintetiza) {
        if (key >= Keys.NumPad0 && key <= Keys.NumPad9) sintetiza.SpeakAsync(((char)(48 + Keys.NumPad0 - key)).ToString());
        if (key >= Keys.D0 && key <= Keys.D9) sintetiza.SpeakAsync(((char)(48 + Keys.D0 - key)).ToString());
    }
}

//https://pt.stackoverflow.com/q/141045/101
