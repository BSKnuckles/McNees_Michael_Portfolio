// Broke this out to it's own class to make it easier to follow while figuring it out
// This is roughly what the Bonus Add Local storage video guides through but with no
// option to remove the animals...

class StoreData {
    // Fetch data from storage
    static GetAnimals(){
        let animals;
        if (localStorage.getItem('pets') === null){
            animals = new Array();
            console.log(`made new array`);
        }
        else{
            animals = JSON.parse(localStorage.getItem('pets'));
            console.log(`Retrieved existing data`);
        }
        return animals;
    }

    // Load the animals into their specific object types
    static LoadAnimals(){
        const storedAnimals = StoreData.GetAnimals();
        storedAnimals.forEach(function(animal){
            // THis was a major headache for a while
            //  Ihad missed the break's between cases and each animal would load it's correct type,
            // as well as every type listed after its type. 
            switch(animal._type){
                case "Dog":
                    {
                        let tmpDog = new Dog(animal._name, animal._gender, animal._age, animal._species);
                        pets.push(tmpDog);
                    }
                    break;
                case "Cat":
                    {
                        let tmpCat = new Cat(animal._name, animal._gender, animal._age, animal._species);
                        pets.push(tmpCat);
                    }
                    break;
                case "Reptile":
                    {
                        let tmpReptile = new Reptile(animal._name, animal._gender, animal._age, animal._species);
                        pets.push(tmpReptile);
                    }
                    break;
                case "Fish":
                    {
                        let tmpFish = new Fish(animal._name, animal._gender, animal._age, animal._species);
                        pets.push(tmpFish);
                    }
                    break;
                case "Amphibian":
                    {
                        let tmpAmphibian = new Amphibian(animal._name, animal._gender, animal._age, animal._species);
                        pets.push(tmpAmphibian);
                    }
                    break;
                case "SmallMammal":
                    {
                        let tmpMammal = new SmallMammal(animal._name, animal._gender, animal._age, animal._species);
                        pets.push(tmpMammal);
                    }
                    break;
                case "Bird":
                    {
                        let tmpBird = new Bird(animal._name, animal._gender, animal._age, animal._species);
                        pets.push(tmpBird);
                    }
                    break;
            }
        })
    }

    // Add an animal to storage
    static SaveAnimal(animal){
        const storedAnimals = StoreData.GetAnimals();
        console.log(storedAnimals);

        storedAnimals.push(animal);

        localStorage.setItem('pets', JSON.stringify(storedAnimals));
    }
}