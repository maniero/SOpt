DisplayMetrics displaymetrics = new DisplayMetrics();
getWindowManager().getDefaultDisplay().getMetrics(displaymetrics);
int height = displaymetrics.heightPixels;
int wwidth = displaymetrics.widthPixels;

//https://pt.stackoverflow.com/q/49601/101
