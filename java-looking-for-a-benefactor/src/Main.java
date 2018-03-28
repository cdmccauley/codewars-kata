public class Main {

    public static long newAvg(double[] arr, double navg) {
        double sum = 0.0;
        long finalDonation;

        for (double number : arr) {
            sum += number;
        }

        finalDonation = (long)Math.ceil(((arr.length + 1) * navg) - sum);

        if (finalDonation >= 0) {
            return finalDonation;
        } else {
            throw new IllegalArgumentException();
        }
    }

    public static void main(String[] args) {
        System.out.println(newAvg(new double[] {14.0, 30.0, 5.0, 7.0, 9.0, 11.0, 15.0}, 30.0)); // 149
        System.out.println(newAvg(new double[] {1400.25, 30000.76, 5.56, 7.0, 9.0, 11.0, 15.48, 120.98}, 10000.0)); // 58430
    }
}
