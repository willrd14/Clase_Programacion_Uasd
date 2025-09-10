package animalshop2;

public class animalTest2 {
    public static void main(String[] args){
        Dog dog = new Dog("Bailey", "Boerboel", "arf-arf", 80.2, "brown");
        Fish fish = new Fish("GoldFish", "cold", "red");

        System.out.println("Dog name: " + dog.getName());
        System.out.println("Dog breed: " + dog.getBreed());
        System.out.println("Bark noise: ");
        dog.bark();
        System.out.println("Dog weight: " + dog.getWeight());
        System.out.println("Dog color: " + dog.getColor());

        System.out.println("Fish breed: " + fish.getBreed());
        System.out.println("Water type: " + fish.getWaterType());
        System.out.println("Fish color: " + fish.getColor());
    }
}