class Plant {
    protected int ID;
    protected string name;
    protected string description;
    protected int amount;
    protected float height;
    protected float circumference;

    public Plant(int ID, string name, string description, int amount, float height, float circumference) {
        this.ID = ID;
        this.name = name;
        this.description = description;
        this.amount = amount;
        this.height = height;
        this.circumference = circumference;
    }

    public string GetPlantName() {
        return this.name;
    }

}