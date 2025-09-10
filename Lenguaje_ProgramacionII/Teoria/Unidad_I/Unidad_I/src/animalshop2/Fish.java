package animalshop2;

public class Fish extends animal{
    private String waterType;

    public Fish(String breed, String waterType, String color){
        super(breed, color);
        this.waterType = waterType;
    }

    public String getWaterType() {
        return waterType;
    }

    public void setWaterType(String waterType) {
        this.waterType = waterType;
    }
}