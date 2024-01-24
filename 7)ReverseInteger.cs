public int Reverse(int x) {
    int reversed = 0;

    while (x != 0) {
        int digit = x % 10;
        x /= 10;

        // Check for integer overflow before updating reversed
        if (reversed > Int32.MaxValue / 10 || (reversed == Int32.MaxValue / 10 && digit > 7)) {
            return 0; // Return 0 for overflow
        }

        if (reversed < Int32.MinValue / 10 || (reversed == Int32.MinValue / 10 && digit < -8)) {
            return 0; // Return 0 for overflow
        }

        reversed = reversed * 10 + digit;
    }

    return reversed;
}