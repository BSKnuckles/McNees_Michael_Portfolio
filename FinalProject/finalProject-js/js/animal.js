// Constructor
// Name
// Gender
// Age
// Species
// Tasks
// Eat
// AddToDiet
// ListHabitatTasks
// AddToHabitatTasks


// Declare Animal Classes
// I moved all Animal and children classes to a single file to keep them organized, but not create a ton of files
// THis also proved useful in testing since they were easier to quickly see multiple at once.
class Animal {

    constructor(name, gender, age, species){
        this._name = name;
        this._gender = gender;
        this._age = age;
        this._species = species;
        this._diet = new Diet();
        this._behaviors = new Array();
        this._habitatTasks = new Array();
        this._type = this.constructor.name;
    }
    
    Name(){
        return this._name;
    }
    Gender() {
        return this._gender;
    }
    Age(){
        return this._age;
    }
    Species(){
        return this._species;
    }
    Tasks(){
        return this._habitatTasks;
    }

    Eat(){
        let foodChoice = "";

        // Check if the diet has any items and if not, give the wizard to add items
        if (!this._diet.HasDiet()){
            this.AddToDiet();
        }

        // Get the user's choice for a food item or to create a new one
        this.ListDiet();
        foodChoice = prompt(this.ListDiet() + `\nChoose a food to feed ${this._name}\nOr enter 'new' to add a new dietary item:`);

        while (foodChoice.toLowerCase() == "new")
        {
            this.AddToDiet();
            this.ListDiet();
            foodChoice = prompt(this.ListDiet() + `\nChoose a food to feed ${this._name}\nOr enter 'new' to add a new dietary item:`);
            if (foodChoice.toLowerCase != "new"){

            }
        }

        let error = '';

        // Loop to get the correct item to feed
        while (!this._diet.Contains(foodChoice))
        {
            error = (`${foodChoice} is not a part of ${this._name}'s diet.`);
            foodChoice = prompt(this.ListDiet() + error + `Choose a food to feed ${this._name}:`);
        }

        let selectedFood = this._diet.Contains(foodChoice);
        // Eat the food
        this._diet.EatFoodItem(selectedFood._food, selectedFood._quantity, this._name);
    }

    AddToDiet(){
        let foodChoice = prompt(`Enter a food to add to ${this._name}'s diet:`);
        let quantity = prompt(`How many grams of ${foodChoice} does ${this._name} eat?`);
        this._diet.AddDietItem(foodChoice, quantity);
    }

    ListDiet(){
        let dietList = `  --  Diet Options  --  `;
        if (this._diet._dietItems.length == 0){
            dietList += `\nThis diet has no items.`;
        }
        else{
            this._diet._dietItems.forEach(i => dietList += `\nFood: ` + i._food + ` Quantity: ` + i._quantity + ` grams`);
        }
        return dietList;
    }
    // Since interfaces don't exist in JS, I created this simple method to determine if a child class is trainable.
    // THis won't enforece creating the required methods, but does at least give me a single place to specify if other
    // child classes should have this ability
    IsTrainable(){
        let type = this.constructor.name;
        switch(type){
            case "Dog":
            {
                return true;
            }
            default:{
                return false;
            }
        }
    }

    ListHabitatTasks(){
        let adding = true;
        while (adding){
            let tasks = '';
            if (this._habitatTasks.length == 0){
                tasks += `\n${this.Name()} does not have any scheduled habitat maintenance tasks.`;
            }
            else{
                for(let i = 0; i < this._habitatTasks.length; i++){
                    let t = this._habitatTasks[i];
                    let p = 'Never';
                    if (t.LastPerformed() == 0){
                        p = `Today`;
                    }
                    else if (t.LastPerformed() != -1){
                        p = `${t.LastPerformed()} days ago`;
                    }
                    tasks += `\n${i+1}. Task: ${t.Name()}\n    Repeats Every: ${t.Frequency()} days\n    Is Due: ${t.IsTaskDue()}\n    Last Completed: ${p}`;
                }
            }

            tasks += `\nChoose a task number or another command.\nCommands: [new] or [cancel]`;

            let choice = prompt(tasks);

            if (choice.toLowerCase() == "cancel"){
                break;
            }
            else if(choice.toLowerCase() == 'new'){
                this.AddToHabitatTasks();
                let keepAdding = prompt("Add another task? (y/n): ");
                switch (keepAdding.toLowerCase())
                {
                    case "y":
                    case "yes":
                        {
                            this.AddToHabitatTasks();
                        }
                        break;
                    case "n":
                    case "no":
                        {
                            adding = false;
                        }
                        break;
                    default:
                        {
                            alert(`Invalid entry: ${keepAdding}`);
                        }
                        break;
                }
            }
            else if (choice >= 0 && choice <= this._habitatTasks.length){
                choice -= 1;
                let tmpTask = this._habitatTasks[choice];
                tmpTask.CompleteTask();
            }
            else{
                alert(`Invalid entry ${choice}.`);
            }
            
        }
    }

    AddToHabitatTasks(){
        let taskName = prompt(`  --  New Habitat Task  --\nEnter the name for this task:`);
        let taskFrequency = prompt(`  --  New Habitat Task  --\nHow many days should pass between performing this task:`);

        let tmpTask = new HabitatTask(taskName, taskFrequency);
        this._habitatTasks.push(tmpTask);

        alert(`Added ${tmpTask.Name()} to ${this.Name()}'s recurring habitat tasks.`);
    }
}
class Dog extends Animal {
    constructor(name, gender, age, species){
        super(name, gender, age, species);
        this._behaviors = new Array();
    }

    ListCommands(){
        let commandsList = `  --  Commands List  --  `;
        if (this._behaviors.length > 0)
        {
            this._behaviors.forEach(b => commandsList += `\nThe ${b._command} command will make ${this.Name()} perform ${b._behavior}.`);
        }
        else
        {
            commandsList += `\n${this.Name()} does not know any commands yet.\nTry teaching some with the [train] option.`;
        }
        return commandsList;
    }

    Train(signal, behavior){
        while (this._behaviors.includes(signal))
        {
            alert(`${this.Name()} already knows a behavior with that signal.\nYou will need to use another signal.`);
            signal = prompt(`Enter a different signal you will use for ${behavior}:`);
        }

        let pronoun = "";
        if (this.Gender().toLowerCase() == "f")
        {
            pronoun = "her";
        }
        else if (this.Gender().toLowerCase() == "m")
        {
            pronoun = "him";
        }
        else
        {
            pronoun = "it";
        }

        let tmpTrain = new Behavior(signal, behavior);

        this._behaviors.push(tmpTrain);
        return `${this.Name()} learned to ${behavior} when you give ${pronoun} the signal: ${signal}`;
    }
}
class Cat extends Animal {
    constructor(name, gender, age, species){
        super(name, gender, age, species);
    }
    // To demonstrate polymorphism, I gave cats an overridden Eat() method
    // This would not be at all useful in the intended use of the app, though
    // it is fun in the context of demonstrating the skill. Cats will randomly
    // not eat based on the random number generator generating an odd or even
    // number
    Eat(){
        let chance = Math.random();
        chance *= 100;
        chance = Math.round(chance);
        if (chance % 2 == 0){
            let foodChoice = "";

        // Check if the diet has any items and if not, give the wizard to add items
        if (!this._diet.HasDiet()){
            this.AddToDiet();
        }

        // Get the user's choice for a food item or to create a new one
        this.ListDiet();
        foodChoice = prompt(this.ListDiet() + `\nChoose a food to feed ${this._name}\nOr enter 'new' to add a new dietary item:`);

        while (foodChoice.toLowerCase() == "new")
        {
            this.AddToDiet();
            this.ListDiet();
            foodChoice = prompt(this.ListDiet() + `\nChoose a food to feed ${this._name}\nOr enter 'new' to add a new dietary item:`);
            if (foodChoice.toLowerCase != "new"){

            }
        }

        let error = '';

        // Loop to get the correct item to feed
        while (!this._diet.Contains(foodChoice))
        {
            error = (`${foodChoice} is not a part of ${this._name}'s diet.`);
            foodChoice = prompt(this.ListDiet() + error + `Choose a food to feed ${this._name}:`);
        }

        let selectedFood = this._diet.Contains(foodChoice);
        // Eat the food
        this._diet.EatFoodItem(selectedFood._food, selectedFood._quantity, this._name);
        }
        else{
            alert(`${this.Name()} ignored your food offering and walked away.`);
        }        
    }
}

// THe rest of the child classes are not any different from the super class. They are created to allow easy expansion in the future
class Reptile extends Animal {
    constructor(name, gender, age, species){
        super(name, gender, age, species);
    }
}
class Fish extends Animal {
    constructor(name, gender, age, species){
        super(name, gender, age, species);
    }
}
class Amphibian extends Animal {
    constructor(name, gender, age, species){
        super(name, gender, age, species);
    }
}
class SmallMammal extends Animal {
    constructor(name, gender, age, species){
        super(name, gender, age, species);
    }
}
class Bird extends Animal {
    constructor(name, gender, age, species){
        super(name, gender, age, species);
    }
}

// Moved the behvaior class to this file rather than creating a totally new file.
// This also made it easier to interact with the Behaviors
class Behavior {
    constructor(command, behavior){
        this._command = command;
        this._behavior = behavior;
    }
}