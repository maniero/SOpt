button1.Enabled = false;
Task.Factory.StartNew(() => {
    // execução lenta aqui, se não for lenta, não faz sentido
}).ContinueWith(task => {
    button1.Enabled = true;
}, TaskScheduler.FromCurrentSynchronizationContext());

//https://pt.stackoverflow.com/q/228099/101
