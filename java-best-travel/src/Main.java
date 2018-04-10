import java.util.Arrays;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.stream.IntStream;

public class Main {

    public static Integer chooseBestSum(int t, int k, List<Integer> ls) {
        int[] currentRoute = new int[k];
        ArrayList<Integer> possibleRoutes = new ArrayList<>();

        if ((ls.size() == 1 && ls.get(0) == null) || ls.size() < k) {
            System.out.println("line 11"); /// DEBUG !!!
            return null;
        } else {
            // still researching...
        }

        return -1;
    }

    public static void main(String[] args) {

	    //System.out.println(chooseBestSum(163, 3, new ArrayList<>(Arrays.asList(50)))); /// null
    }
}
