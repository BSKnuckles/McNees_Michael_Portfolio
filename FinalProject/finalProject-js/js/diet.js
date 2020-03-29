// Constructor
// AddDietItem
// EatFoodItem
// CanEat
// HasDiet
// ListDiet

class Diet {

    constructor(){
        this._dietItems = new Array();
    }

    AddDietItem(food, quantity){
        let tmpFood = new FoodItem(food, quantity);
        this._dietItems.push(tmpFood);
        alert(`Successfully added ${food} to the diet!`);
        
    }

    EatFoodItem(food, quantity, petName){
        if (this.Contains(food)){
            alert(`${petName} ate ${quantity} grams of ${food}!`)
        }
        else{
            alert(`${petName} doesn't eat ${food}.`)
        }
    }

    HasDiet(){
        if (this._dietItems.length > 0){
            return true;
        }
        else{
            return false;
        }
    }

    Contains(food){
        for (let i = 0; i < this._dietItems.length; i++){
            if (this._dietItems[i].Food() == food){
                // Returning ther food item for 
                return this._dietItems[i];
            }
        }
        return 0;
    }
}

class FoodItem {
    constructor(food, quantity){
        this._food = food;
        this._quantity = quantity;
    }

    Food(){
        return this._food;
    }
    Quantity(){
        return this._quantity;
    }
}