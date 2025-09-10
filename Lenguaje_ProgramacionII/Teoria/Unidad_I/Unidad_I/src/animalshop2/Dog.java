package animalshop2;

public class Dog extends animal{
    private String name;
    private String barkNoise = "Woof";
    private double weight;

    public Dog(String name, String breed, double weight, String color){
        super(breed, color);
        this.name = name;
        this.weight = weight;
    }

    public Dog(String name, String breed, String noise, double weight, String color){
        super(breed, color);
        this.name = name;
        barkNoise = noise;
        this.weight = weight;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public double getWeight(){
        return weight;
    }

    public void setWeight(double weight){
        this.weight = weight;
    }

    public void bark(){
        System.out.println(barkNoise);
    }

    public void bark(String barkNoise){
        System.out.println(barkNoise);
    }
}