package animalshop2;

public class animal{
    private String breed, color;

    public animal(String breed, String color){
        this.breed = breed;
        this.color = color;
    }

    public String getBreed(){
        return breed;
    }

    public void setBreed(String breed){
        this.breed = breed;
    }

    public String getColor(){
        return color;
    }

    public void setColor(String color){
        this.color = color;
    }
}