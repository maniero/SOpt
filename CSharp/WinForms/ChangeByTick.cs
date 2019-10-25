private PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total"); 

private void timer1_Tick(object sender, EventArgs e) => label42.Text = cpuCounter.NextValue().ToString();

//https://pt.stackoverflow.com/q/97666/101
