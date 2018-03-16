public class Main {

    public static class Fighter {
        public String name;
        public int health, damagePerAttack;

        public Fighter(String name, int health, int damagePerAttack) {
            this.name = name;
            this.health = health;
            this.damagePerAttack = damagePerAttack;
        }
    }

    public static String declareWinner(Fighter fighter1, Fighter fighter2, String firstAttacker) {
        Fighter attacker, defender;
        String winner = new String();

        if (fighter1.name.equals(firstAttacker)) {
            attacker = fighter1;
            defender = fighter2;
        } else {
            attacker = fighter2;
            defender = fighter1;
        }

        do {
            if (defender.health > 0 && attacker.health > 0) {
                defender.health -= attacker.damagePerAttack;
                if (defender.health > 0) {
                    System.out.println(attacker.name + " attacks " + defender.name + "; " +
                            defender.name + " now has " + defender.health + " health.");
                } else {
                    System.out.println(attacker.name + " attacks " + defender.name + "; " +
                            defender.name + " now has " + defender.health + " health and is dead. " + attacker.name + " wins.");
                    winner = attacker.name;
                }
            }
            if (attacker.health > 0 && defender.health > 0) {
                attacker.health -= defender.damagePerAttack;
                if (attacker.health > 0) {
                    System.out.println(defender.name + " attacks " + attacker.name + "; " +
                            attacker.name + " now has " + attacker.health + " health.");
                } else {
                    System.out.println(defender.name + " attacks " + attacker.name + "; " +
                            attacker.name + " now has " + attacker.health + " health and is dead. " + defender.name + " wins.");
                    winner = defender.name;
                }
            }
        } while (attacker.health > 0 && defender.health > 0);

        return winner;
    }

    public static void main(String[] args) {
        Fighter fighter1 = new Fighter("Lew", 10, 2);
        Fighter fighter2 = new Fighter("Harry", 5, 4);

        System.out.println(declareWinner(fighter1, fighter2, "Harry"));
    }
}
