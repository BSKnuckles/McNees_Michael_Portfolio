// Original plan based on completed C# App
// Main
// selectAnimal
// newPetWizard
// TrainPet
// Habitat
// SaveAnimalData
// LoadAnimalData
// Wait
// Header

// I intentionally did very little outputting to the console since the user is expected to
// enter items through the prompt popup, it felt more intuitive to provide feedback through
// alerts and the prompts

// I ran out of time to do the input validation class for this version....
// I did put most *important* prompts within a loop to ensure they got correct
// input though and provided the feedback for these scenarios.

// Adding these banners here was a neat way for me to re-use interface elements in the alerts
const header = ` ____      _   _       \n|  _ \\ ___| |_| |_   _ \n| |_) / _ \\ __| | | | |\n|  __/  __/ |_| | |_| |\n|_|   \\___|\\__|_|\\__, |\n                 |___/ \n`;
const MainMenuBanner        = `-----------------------\n----   Main Menu   ----\n-----------------------\n`;
const PetSelectionBanner    = `-----------------------\n-    Pet Selection    -\n-----------------------\n`;
const FeedingBanner         = `-----------------------\n----    Feeding    ----\n-----------------------\n`;
const HabitatBanner         = `-----------------------\n- Habitat Maintenance -\n-----------------------\n`;
const NewPetWizardBanner    = `-----------------------\n--   New Pet Wizard  --\n-----------------------\n`;
const TypeSelectionBanner   = `-----------------------\n--   Type Selection  --\n-----------------------\n`;


// Initializing some variables I'll need throughout the app
var pets = new Array();
StoreData.LoadAnimals();
var activePet = null;
var running = true;


// Main program loop
while (running){
    console.clear();
    console.log(header);
    if (activePet !== null){
        console.log(` Pet: ${activePet.Name()}`);
    }
    let mainMenu = ` 1. Pet Selection\n 2. Feeding\n 3. Training\n 4. Habitat Maintenance\n 0. Exit / Quit\n\n`;

    // Prompts are SO much more efficient for gathering input than the process in C#
    let input = prompt(MainMenuBanner + mainMenu + `Select an option: `);

    switch(input){
        case "1":
        case "pet selection":
            {
                activePet = SelectAnimal(activePet);
            }
            break;
        case "2":
        case "feeding":
            {
                while (activePet === null)
                {
                    activePet = SelectAnimal(activePet);
                }

                activePet.Eat();
            }
            break;
        case "3":
        case "training":
            {
                while (activePet === null)
                {
                    activePet = SelectAnimal(activePet);
                }

                TrainPet(activePet);
            }
            break;
        case "4":
        case "habitat maintenance":
            {
                while (activePet === null)
                {
                    activePet = SelectAnimal(activePet);
                }

                Habitat(activePet);
            }
            break;
        case "0":
        case "quit":
        case "exit":
        case "q":
        case "x":
            {
                running = false;
            }
            break;
        default:
            {
                alert(`Invalid option: ${input}`);
            }
            break;
    }
}


function SelectAnimal(currentPet){
    if (pets === null || pets.length === 0)
    {
        currentPet = NewPetWizard();

        if ((currentPet.Name()) != null)
        {
            
            alert(`Successfully created ${currentPet.Name()}'s record!`);
        }
        else
        {
            console.log(`An error occurred.`);
        }
    }
    else
    {
        // Building these nested functions was interesting and not something I had done in C#
        // Not sure if this is "ok" or "normal" though
        var petsCount = function(){
            // I got stuck trying to use array.count for a bit too long...
            if (pets.length == undefined){
                return "0";
            }
            else{
                return pets.length;
            }
        }

        var petMenu = function(){
            let menuString = `0. Add New Pet`;
            console.log(pets.length);
            pets.forEach(p => console.log(p._name));
            for (let i = 0; i < pets.length; i++)
            {
                menuString += `\n${i + 1}. ${pets[i].Name()} the ${pets[i].Species()}`;
            }
            return menuString;
        }
        
        let input = prompt(PetSelectionBanner + petMenu() + `\nChoose an option (0-${petsCount()}):`);
        if (input != 0)
        {
            currentPet = pets[input - 1];
            alert(`Successfully picked ${currentPet.Name()}!`);
        }
        else
        {
            currentPet = NewPetWizard();

            if (currentPet.Name() != null)
            {
                alert(`Successfully created ${currentPet.Name()}'s record!`);
            }
            else
            {
                alert(`An error occurred.`);
            }
        }
    }
    return currentPet;
}

function NewPetWizard(){
    let petName = prompt(NewPetWizardBanner + `Enter the pet's name:`);
    let petGender = prompt(NewPetWizardBanner + `What is ${petName}'s gender (m/f):`);
    let petAge = prompt(NewPetWizardBanner + `What is ${petName}'s age in years:`);
    let petSpecies = prompt(NewPetWizardBanner + `What is ${petName}'s species:`);

    let petType = prompt(TypeSelectionBanner + ` 1. Dog\n 2. Cat\n 3. Reptile\n 4. Fish\n 5. Amphibian\n 6. Small Mammal\n 7. Bird\n\nChoose ${petName}'s type:`);

    switch (petType)
    {
        case "1":
        case "dog":
            {
                let tmpDog = new Dog(petName, petGender, petAge, petSpecies);

                // Add to local storage
                // I wish I could have found a better way to not just save these, but update them, after they were saved...
                StoreData.SaveAnimal(tmpDog);
                pets.push(tmpDog);
                return tmpDog;
            }
        case "2":
        case "cat":
            {
                let tmpCat = new Cat(petName, petGender, petAge, petSpecies);
                StoreData.SaveAnimal(tmpCat);
                pets.push(tmpCat);
                return tmpCat;
            }
        case "3":
        case "reptile":
            {
                let tmpReptile = new Reptile(petName, petGender, petAge, petSpecies);
                StoreData.SaveAnimal(tmpReptile);
                pets.push(tmpReptile);
                return tmpReptile;
            }
        case "4":
        case "fish":
            {
                let tmpFish = new Fish(petName, petGender, petAge, petSpecies);
                StoreData.SaveAnimal(tmpFish);
                pets.push(tmpFish);
                return tmpFish;
            }
        case "5":
        case "amphibian":
            {
                let tmpAmphibian = new Amphibian(petName, petGender, petAge, petSpecies);
                StoreData.SaveAnimal(tmpAmphibian);
                pets.push(tmpAmphibian);
                return tmpAmphibian;
            }
        case "6":
        case "small mammal":
            {
                let tmpMammal = new SmallMammal(petName, petGender, petAge, petSpecies);
                StoreData.SaveAnimal(tmpMammal);
                pets.push(tmpMammal);
                return tmpMammal;
            }
        case "7":
        case "bird":
            {
                let tmpBird = new Bird(petName, petGender, petAge, petSpecies);
                StoreData.SaveAnimal(tmpBird);
                pets.push(tmpBird);
                return tmpBird;
            }
        default:
            {
                Console.WriteLine(`Invalid entry: ${petSpecies}.\n  Please try again.`);
            }
            break;
    }
    // Providing a fallback option in case the user somehow manages to find a way to make something that doesn't match one of the types
    // This shouldn't be possible though...
    let tmpAnimal = new Animal(petName, petGender, petAge, petSpecies);
    StoreData.SaveAnimal(tmpAnimal);
    pets.push(tmpAnimal);
    return tmpAnimal;
}

// This whole method feels clunky to me at this point...
// I'm checking multiple times to see if the pet is, in fact, trainable. This should really be checked once IMO
// I just couldn't think through the right nesting/structure to make that possible
function TrainPet(activePet){
    while(!activePet.IsTrainable()){
        // Limit the loop to 3 times in case you keep creating untrainable animals
        for (let i = 0; i < 3; i++){
            alert(`${activePet.Name()} is not trainable. Please select another animal.`)
            activePet = SelectAnimal(activePet);
            if(activePet.IsTrainable()){
                break;
            }
        }
        if (!activePet.IsTrainable()){
            alert(`You've created 3 untrainable pets. Going back to the Main Menu...`);
            break;
        }
        
        
    }
    if (activePet.IsTrainable()){
        let choice = prompt(`  --  Training  --\n1. [train]  Teach ${activePet.Name()} a new behavior.\n2. [list]   List ${activePet.Name()}'s known behaviors..\nChoose an option:`).toLowerCase();
        switch (choice)
        {
            case "1":
            case "train":
                {
                    let behavior = prompt(`Enter the behavior you are training ${activePet.Name()} to do:`);
                    let signal = prompt(`Enter the signal you will use for ${behavior}:`);
    
                    activePet.Train(signal, behavior);
                }
                break;
            case "2":
            case "list":
                {
                    alert(activePet.ListCommands());
                }
                break;
            default:
                {
                    alert(`${choice} is not a valid option.`);
                }
                break;
        }
    }
    
}

function Habitat(currentPet){
    currentPet.ListHabitatTasks();
}