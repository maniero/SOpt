public static BigDecimal powerBig(BigDecimal base, BigDecimal exponent) {
    BigDecimal ans = new BigDecimal(1.0);
    BigDecimal k = new BigDecimal(1.0);
    BigDecimal t = new BigDecimal(-1.0);
    BigDecimal no = new BigDecimal(0.0);
    if (exponent != no) {
        BigDecimal absExponent =  exponent.signum() > 0 ? exponent : t.multiply(exponent);
        while (absExponent.signum() > 0){
            ans =ans.multiply(base);
            absExponent = absExponent.subtract(BigDecimal.ONE);
        }
        if (exponent.signum() < 0) {
            // For negative exponent, must invert
            ans = k.divide(ans);
        }
    } else {
        // exponent is 0
        ans = k;
    }
    return ans;
}

//https://pt.stackoverflow.com/q/251848/101
