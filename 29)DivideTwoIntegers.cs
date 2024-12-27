public class Solution {
    public int Divide(int dividend, int divisor) {
        // Handle special cases for 32-bit integer overflow
        if (dividend == int.MinValue && divisor == -1) {
            return int.MaxValue;
        }
        
        // Convert to long to handle int.MinValue edge cases
        long dvd = Math.Abs((long)dividend);
        long dvs = Math.Abs((long)divisor);
        int sign = (dividend > 0) ^ (divisor > 0) ? -1 : 1;
        long quotient = 0;
        
        // Main division logic using bit manipulation
        while (dvd >= dvs) {
            long temp = dvs;
            long multiple = 1;
            
            // Find the largest multiple of divisor that's <= dividend
            while (dvd >= (temp << 1)) {
                temp <<= 1;
                multiple <<= 1;
            }
            
            dvd -= temp;
            quotient += multiple;
        }
        
        // Apply sign and handle overflow
        quotient *= sign;
        
        // Handle 32-bit integer bounds
        if (quotient > int.MaxValue) return int.MaxValue;
        if (quotient < int.MinValue) return int.MinValue;
        
        return (int)quotient;
    }
}