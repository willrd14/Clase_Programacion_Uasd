package animalshop;

public class animalTest {
    public static void main(String[] args) {
        dog dog1 = new dog("Ace", "Beagle", 45.6);
        dog dog2 = new dog("Baby", "Boerboel", "arf-arf", 80.2);

        System.out.println("Dog name: " + dog1.getName());
        System.out.println("Dog breed: " + dog1.getBreed());
        System.out.println("Bark noise: ");
        dog1.bark();
        System.out.println("Dog weight: " + dog1.getWeight());

        System.out.println("Dog name: " + dog2.getName());
        System.out.println("Dog breed: " + dog2.getBreed());
        System.out.println("Bark noise: ");
        dog2.bark();
        System.out.println("Dog weight: " + dog2.getWeight());
    }
}