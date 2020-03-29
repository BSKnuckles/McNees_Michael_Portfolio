// Constructor
// Name
// Frequency
// LastPerformed
// IsTaskDue
// CompleteTask

class HabitatTask{
    constructor(name, frequency){
        this._name = name;
        this._frequency = frequency;
        this._lastPerformed = null;
    }

    Name(){
        return this._name;
    }
    Frequency(){
        return this._frequency;
    }

    // This was a pain to figure out!
    // I ultimately found a guide online for calculating the number of days until Christmas and got my head around Date objects
    // In the C# app I also return -1 if the difference was over a large number of days to accomplish the same thing as checking
    // the date to see if it was Dec 31 1969.
    LastPerformed(){
        let one_day = 1000 * 60 * 60 * 24;
        let today = new Date();
        let last = new Date(this._lastPerformed);
        let days = Math.round(today.getTime() - last.getTime()) / (one_day);
        let final_days = days.toFixed(0);

        if (last == 'Wed Dec 31 1969 19:00:00 GMT-0500 (Eastern Standard Time)'){
            return -1;
        }

        return final_days;
    }

    IsTaskDue(){
        if(this.LastPerformed() == 0){
            return false;
        }
        else if (this.LastPerformed() == -1){
            return true;
        }
        else{
            return true;
        }
    }

    CompleteTask(){
        this._lastPerformed = new Date(Date.now());
        alert(`Completed ${this._name}!`);
    }
}