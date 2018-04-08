import java.util.Arrays;
import java.util.ArrayList;
import java.util.List;

public class Main {

    public static Integer chooseBestSum(int t, int k, List<Integer> ls) {
        int currentRoute;

        if ((ls.size() == 1 && ls.get(0) == null) || ls.size() < k) {
            System.out.println("line 11"); /// DEBUG !!!
            return null;
        } else {
            for (int i = 0; i < ls.size() - 1; i++) {
                currentRoute = ls.get(i);
                for (int j = i; j < ls.size() - 1; j++) {
                    // working on algorithm...
                }
            }
        }

        return -1;
    }

    public static void main(String[] args) {

	    System.out.println(chooseBestSum(163, 3, new ArrayList<>(Arrays.asList(50)))); /// null


    }
}
