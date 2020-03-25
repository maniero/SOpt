Parallel.For(0, original.Height, j => {
    for (int i = 0; i < original.Width; i++) {
        Color corOriginal = original.GetPixel(i, j);
        int escalaCinza = (int)((corOriginal.R * 0.3) + (corOriginal.G * 0.49) + (corOriginal.B * 0.11));
        Color CorEmEscalaDeCinza = Color.FromArgb(escalaCinza, escalaCinza, escalaCinza);
        alterado.SetPixel(i, j, CorEmEscalaDeCinza);
    }
});

//https://pt.stackoverflow.com/q/169079/101
