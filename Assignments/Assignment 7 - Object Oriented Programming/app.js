// Assignment 7: Object Oriented Programming
// WD2 - C202003 01
// Michael McNees
// 03/21/20

class Animal {
    constructor(species, age, food, name){
        this._age = age;
        this._species = species;
        this._food = food;
        this._name = name;
    }
    feed(){
        console.log(`${this._name} ate the ${this._food}.`);
    }
    getSpecies(){
        return this._species;
    }
    getName(){
        return this._name;
    }
}

class Snake extends Animal {
    constructor(species, age, food, climate, gender, name){
        super(species, age, food, name);
        this._climate = climate;
        this._gender = gender;
    }
    probe(){
        if (this._gender.toUpperCase() === "MALE"){
            console.log(`The ${this.getSpecies()} named ${this.getName()} is a male and will be slightly smaller than his female counterparts.`);
        }
        else if(this._gender.toUpperCase() === "FEMALE"){
            console.log(`The ${this.getSpecies()} named ${this.getName()} is a female and will be slightly larger than her male counterparts.`);
        }
    }
    feed(){
        console.log(`${this.getName()}, the ${this.getSpecies()}, ate the ${this._food}.`);
    }
}

const Harold = new Snake("Corn Snake", 5, "Large Mouse", "Temperate", "Female", "Harold");
const Kumar = new Snake("Corn Snake", 5, "Small Mouse", "Temperate", "Male", "Kumar");
const Aurora = new Animal("Pomeranian", 1, "Kibble", "Aurora");

Harold.feed();
Kumar.feed();
Kumar.probe();
Harold.probe();
Aurora.feed();