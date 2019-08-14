var start = new LocalDateTime(2014, 1, 1, 8, 30);
var end = new LocalDateTime(2014, 9, 16, 12, 0);
Period delay = new PeriodBuilder { 
        Months = 8, 
        Days = 10,
        Hours = 2,
        Minutes = 20
    }
    .Build();
Period difference = (Period.Between(start, end) - delay).Normalize();

//https://pt.stackoverflow.com/q/53891/101
